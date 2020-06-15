using AutomationPractice.Models;

namespace AutomationPractice.Factories
{
    public static class PracticeFormFactory
    {
        public static PracticeFormModel Create()
        {
            return new PracticeFormModel
            {
                Title = "Mrs",
                FirstName = "JN",
                LastName = "JVN",
                Password = "12345",
                FirstAddressField = "7575 Gateway Blvd",
                City = "Newark",
                State = "California",
                PostCode = "94560",
                MobilePhone = "5555544444",
            };
        }
    }
}
