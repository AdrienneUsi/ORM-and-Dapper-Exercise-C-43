using System;
namespace BestBuyBestPractices
{
	public interface IDepartmentRepository
	{
		public IEnumerable<Department> GetAllDepartment();
	}
}

