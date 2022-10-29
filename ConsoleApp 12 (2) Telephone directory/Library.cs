
namespace ConsoleApp_12__2_
{
    public class Library
    {
        private Person[] _persons;

        public Library()
        {
            _persons = new [] {                
                new Person("Stepanov", "Roman", "+380671111111", "+380441111111 ", "+380951111111"),
                new Person("Molchanov", "Igor", "+380672222222", "+380442222222", "+380952222222"),
                new Person("Vovchenko", "Oleg", "+380673333333", " ", "+380953333333"),
                new Person("Boyko", "Petro", "+380674444444", "+380444444444", "+380954444444"),
                new Person("Dolgov", "Bohdan", "+380675555555", "+380445555555", "+380955555555")
            };
        }

        public string SearchByNumber(NumberType numberType, string number)
        {
            foreach (var person in _persons)
            {
                if (numberType == NumberType.mobileNumber && person.MobileNumber == number)
                {
                    return person.Surname + " " + person.Name + ", his worknumber is  " + person.WorkNumber;
                }
                if (numberType == NumberType.workNumber && person.WorkNumber == number)
                {
                    return person.Surname + " " + person.Name;
                }
                if (numberType == NumberType.officialNumber && person.OfficialNumber == number)
                {
                    return person.Surname + " " + person.Name + ", his worknumber is  " + person.WorkNumber;
                }
            }
            return "There is no phone Subscriber at this phone number";
        }

        public string SearchByName(string lookingForSurnamePerson)
        {
            foreach (var person in _persons)
            {
                if (lookingForSurnamePerson == person.Surname)
                {
                    return person.Surname + " " + person.Name + ", his worknumber is  " + person.WorkNumber + ", his oficialnumber is  " + person.OfficialNumber;
                }              
            }
            return "There is no phone Subscriber with this surname";
        }
    }
}
