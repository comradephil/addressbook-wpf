using System;

public class AddressBook
{
	public void FileReader(string pathToRead)
	{
		try
		{
			File.ReadAllLines(pathToRead);
		}
		catch (Exception)
		{
			Console.WriteLine("Couldn't find the contact file specified - check it exists");
			throw;
		}
		finally
		{
			Console.WriteLine("Press any key to quit");
		}
	}
}
