namespace Ex2.Human
{
    using System;

    public class HumanCreator
    {
        public void MakeHuman(Gender gender)
        {
            Human newHuman = new Human();
            newHuman.Gender = gender;
            if (gender == Gender.Male)
            {
                newHuman.Name = "Батката";
                newHuman.Gender = Gender.Male;
            }
            else
            {
                newHuman.Name = "Мацето";
                newHuman.Gender = Gender.Female;
            }
        }
    }
}
