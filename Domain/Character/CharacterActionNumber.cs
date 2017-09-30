namespace Domain.Character
{
    public class CharacterActionNumber
    {
        public int UndefinedActionNumber { get; set; }
        public int CombatActionNumber { get; set; }
        public int MeleeActionNumber { get; set; }
        public int RangedActionNumber { get; set; }
        public int MoveActionNumber { get; set; }
        public int SearchActionNumber { get; set; }

        public CharacterActionNumber()
        {
            UndefinedActionNumber = 3;
            CombatActionNumber = 0;
            MeleeActionNumber = 0;
            RangedActionNumber = 0;
            MoveActionNumber = 0;
            SearchActionNumber = 0;
        }
    }
}