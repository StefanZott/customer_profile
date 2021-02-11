using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFile.Model
{
    public class Customer
    {
        public string lastName { get; }
        public String firstName { get; }
        private String streetName { get; }
        private int houseNumber { get; }
        private int postCode { get; }
        private String place { get; }

        private List<Bill> billList;

        public Customer(String lastName, String firstName, String streetName, int houseNumber, int postCode, String place) {
            billList = new List<Bill>();
            this.lastName = lastName;
            this.firstName = firstName;
            this.streetName = streetName;
            this.houseNumber = houseNumber;
            this.postCode = postCode;
            this.place = place;
        }

        public void addBillInList()
        {
            Bill b = new Bill();
            billList.Add(b);
        }


    }
}
