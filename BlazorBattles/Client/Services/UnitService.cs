using BlazorBattles.Shared;
using Blazored.Toast.Services;

namespace BlazorBattles.Client.Services
{
    public class UnitService : IUnitService
    {
        private readonly IToastService _toastService;

        public UnitService(IToastService toastService)
        {
            _toastService = toastService;
        }

        public IList<Unit> Units => new List<Unit>()
        {
            new Unit { ID = 1, Title = "Knight", Attack = 10, Defense = 10, BananaCost = 100 },
            new Unit { ID = 2, Title = "Archer", Attack = 15, Defense = 5, BananaCost = 150 },
            new Unit { ID = 3, Title = "Mage", Attack = 20, Defense = 1, BananaCost = 200 }
        };
        public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();

        public void AddUnit(int unitId)
        {
            var unit = Units.FirstOrDefault(x => x.ID == unitId);
            if (unit != null)
            {
                MyUnits.Add(new UserUnit() { UnitId = unit.ID, HitPoints = unit.HitPoints });
                _toastService.ShowSuccess($"{unit.Title} has been recruited to your army", "Unit Built");
            }
        }
    }
}
