namespace PlayRiggedGames.Models
{
    public class SlotRowWin
    {
        public string? Message { get; set; }
        public string? Symbol { get; set; }
        public float Payout { get; set; }
        public int Index { get; set; }

        public SlotRowWin(string? message, string? symbol, float payout, bool special, int index)
        {
            Message = message;
            Symbol = symbol;
            Payout = payout;
            Index = index;
        }
    }
}
