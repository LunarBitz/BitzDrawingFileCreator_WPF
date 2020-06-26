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
                AppKey = "",
                UserToken = ""
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

        public void AddTrelloCard(IBoard workingBoard)
        {
            try
            {
                var list = workingBoard.Lists;
                //var card = list.Cards.Add("new card");
                //var member = board.Members.First();
                //card.Members.Add(member);

                list.ForEach(i => Console.Write("{0}\t", i));
                //System.Diagnostics.Debug.WriteLine(list);

            }
            catch
            {
                Console.WriteLine("Unexpected Error With Trello Handling!");
            }
            
        }
    }
}
