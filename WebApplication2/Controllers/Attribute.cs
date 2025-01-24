#region Methods
using System.Web.Http;

//[Authorize]

//[HttpGet]

 static List<CustomerModel> GetCustomerList()
{
	var customerList = new List<CustomerModel>();

	var serviceResponse = _customerservice.GetCustomerList();

	foreach (var item in serviceResponse)
	{
		var model = new CustomerModel()
		{
			
			
		};
		customerList.Add(model);
	}
	return customerList;
}

internal class _customerservice
{
	internal static IEnumerable<object> GetCustomerList()
	{
		throw new NotImplementedException();
	}
}

internal class CustomerModel
{
}
#endregion