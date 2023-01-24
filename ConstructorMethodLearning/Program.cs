using ConstructorMethodLearning; 

Character firstChar = new Character();
firstChar.Name = "EtEllerAndet";

//The method is static, so it runs on the class and not on the object. 
firstChar.CharacterClass = Character.GetCharacterClassRandomly();

