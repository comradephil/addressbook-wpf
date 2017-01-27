namespace AddressBook
{
	internal class Contact
	{
		public string firstName = "";
		public string lastName = "";
		public string emailAddress = "";
		public string phoneNumber = "";

		public Contact()
		{
			
		}

		public Contact(string firstName, string lastName, string emailAddress, string phoneNumber)
		{
			this.firstName = firstName.ToString();
			this.lastName = lastName.ToString();
			this.emailAddress = emailAddress.ToString();
			this.phoneNumber = phoneNumber.ToString();
		}
	}


}