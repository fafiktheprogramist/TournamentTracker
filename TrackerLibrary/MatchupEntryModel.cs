namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in matchup
        /// </summary>
        public TeamModel TeamCompiting { get; set; }
        /// <summary>
        /// Represents Score for particulair team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents matchup that this team came from as a winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore"></param>
        public MatchupEntryModel(double initialScore)
        {
            Console.WriteLine("nothing rly important to read");
        }
    }
}