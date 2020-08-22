using System.Collections.Generic;

namespace StockJocky.Domain.Models
{
	public class User 
	{
		public int Id {get; set;}
		public string Username {get; set;}

		public string Password {get; set;}

		public List<Stock> Stocks = new List<Stock>();

		public decimal Balance {get; set;} //To be used if we implement Stock Trading Game feature.

		public User()
		{
			
		}

		public void AddStock(Stock stock)
		{
			if(!(Stocks.Exists(s => s.Symbol == stock.Symbol))) //If doesn't exist, add stock to list.
			{
				Stocks.Add(stock);
			}
		}

		public void RemoveStock(Stock stock)
		{
			if(Stocks.Exists(s => s.Symbol == stock.Symbol)) //If does exist, remove stock from list.
			{
				Stocks.Remove(stock);
			}
		}
	}
}