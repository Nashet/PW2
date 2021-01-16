namespace PW2.Scripts.Services.Interfaces
{
	public interface IWorldDescriberService :IPopulated
	{
		// IEnumerable<Province> AllProvinces();
		// IEnumerable<SeaProvince> AllSeaProvinces();
		// IEnumerable<AbstractProvince> AllAbstractProvinces();
		// Province FindProvince(int number);
		//
		// IEnumerable<Country> AllExistingCountries();
		// IEnumerable<Market> AllMarkets();
		// IEnumerable<Factory> AllCultures();
		//
		// /// <summary>
		// /// Gives list of allowed IInvestable with pre-calculated Margin in Value. Doesn't check if it's invented
		// /// </summary>
		// // IEnumerable<KeyValuePair<IInvestable, Procent>> GetAllAllowedInvestments(Agent investor);
		// // IEnumerable<KeyValuePair<IShareOwner, Procent>> GetAllShares();
		// // IEnumerable<KeyValuePair<IShareable, Procent>> GetAllShares(IShareOwner owner);
		// Money GetAllMoney();
	}

	public interface IPopulated
	{
	}
}