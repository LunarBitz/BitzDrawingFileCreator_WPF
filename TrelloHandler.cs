using Manatee.Trello;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitzDrawingFileCreator_WPF
{
    public class TrelloHandler
    {
        public TrelloAuthorization _auth;
        private TrelloFactory _factory;

        public void AuthTrello() 
        {
            _auth = new TrelloAuthorization
            {
                AppKey = MainWindow.publicDataContext.trelloApiKey,
                UserToken = MainWindow.publicDataContext.trelloToken
            };

            _factory = new TrelloFactory();
        }

        public async Task<IBoard> _GetTrelloBoardAsync(string boardID)
        {
                var _tempBoard = _factory.Board(boardID, _auth);
                await _tempBoard.Lists.Refresh();
                return _tempBoard;
        }

        public IBoard GetTrelloBoard(string boardID)
        {
            // Run and get async function return without deadlocking
            var CachedItem = Task.Run(async () =>
                    await _GetTrelloBoardAsync(boardID)
                ).Result;
            Console.WriteLine("Board Retrieved!");

            //System.Diagnostics.Debug.WriteLine("Retrieved Board: " + CachedItem);
            return CachedItem;
        }

        public async void AddTrelloCard(IBoard workingBoard)
        {
            try
            {
                var list = workingBoard.Lists[MainWindow.publicDataContext.trelloDefaultList];
                var card = await list.Cards.Add("NEW");
                card.Name = "[" + MainWindow.publicDataContext.drawingProduct + "] " + MainWindow.publicDataContext.userName;
                card.Description = MainWindow.publicDataContext.drawingDescription;

                //list.ForEach(i => Console.Write("{0}\t", i));
                Console.WriteLine(list);

            }
            catch
            {
                Console.WriteLine("Unexpected Error With Trello Handling!");
            }
            
        }
    }
}
