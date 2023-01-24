namespace ConstructorMethodLearning
{
    internal class Character //model class
    {
        //Because the method that uses this array is static, the array is also static. 
        private static string[] characterClass = { "Warrior", "Wizard", "Priest", "Rouge", "Summoner", "Druid", "Ranger" };
        public string Name { get; set; } = "NoNameYet";
        public string CharacterClass { get; set; }
        public DateTime Birthday { get; set; }


        public Character()
        {
            GetRandomBirthday();

        }

        private void GetRandomBirthday()
        {
            Random random = new Random();

            DateTime start = new DateTime(1020, 1, 1);
            DateTime end = new DateTime(1120, 1, 1);
            int range = (end - start).Days;
            int days = random.Next(range);
            Birthday = start.AddDays(days);
        }

        public static string GetCharacterClassRandomly()
        {
            Random random = new Random();
            int r = random.Next(CharacterClass.Length);
            string cc = CharacterClass[r];
            return cc;


            // return characterClass[new Random().Next(characterClass.Length)]; // Samme som det oven over. 

        }


    }
}
