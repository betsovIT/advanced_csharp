namespace PlayersAndMonsters.Core
{
    using System;
    using System.Text;
    using Contracts;
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Models.BattleFields;
    using PlayersAndMonsters.Models.Cards;
    using PlayersAndMonsters.Models.Cards.Contracts;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories;
    using PlayersAndMonsters.Repositories.Contracts;

    public class ManagerController : IManagerController
    {
        private IPlayerRepository playerRepository;
        private ICardRepository cardRepository;

        public ManagerController()
        {
            playerRepository = new PlayerRepository();
            cardRepository = new CardRepository();
        }

        public string AddPlayer(string type, string username)
        {
            if (type == "Beginner")
            {
                playerRepository.Add(new Beginner(new CardRepository(), username));
                return string.Format(ConstantMessages.SuccessfullyAddedPlayer, type, username);
            }
            else if (type == "Advanced")
            {
                playerRepository.Add(new Advanced(new CardRepository(), username));
                return string.Format(ConstantMessages.SuccessfullyAddedPlayer, type, username);
            }
            else
            {
                return null;
            }
        }

        public string AddCard(string type, string name)
        {
            if (type == "Magic")
            {
                cardRepository.Add(new MagicCard(name));
                return string.Format(ConstantMessages.SuccessfullyAddedCard, type, name);
            }
            else if (type == "Trap")
            {
                cardRepository.Add(new TrapCard(name));
                return string.Format(ConstantMessages.SuccessfullyAddedCard, type, name);
            }
            else
            {
                return null;
            }
        }

        public string AddPlayerCard(string username, string cardName)
        {
            var player = playerRepository.Find(username);
            var card = cardRepository.Find(cardName);

            player.CardRepository.Add(card);

            return string.Format(ConstantMessages.SuccessfullyAddedPlayerWithCards, cardName, username);
        }

        public string Fight(string attackUser, string enemyUser)
        {
            var atackPlayer = playerRepository.Find(attackUser);
            var enemyPlayer = playerRepository.Find(enemyUser);
            var battlefield = new BattleField();

            battlefield.Fight(atackPlayer, enemyPlayer);

            return string.Format(ConstantMessages.FightInfo, atackPlayer.Health, enemyPlayer.Health);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (IPlayer player in playerRepository.Players)
            {
                sb.AppendLine(string.Format(ConstantMessages.PlayerReportInfo, player.Username, player.Health, player.CardRepository.Count));
                foreach (ICard card in player.CardRepository.Cards)
                {
                    sb.AppendLine(string.Format(ConstantMessages.CardReportInfo, card.Name, card.DamagePoints));
                }
                sb.AppendLine(ConstantMessages.DefaultReportSeparator);
            }

            return sb.ToString().TrimEnd();
        }
    }
}