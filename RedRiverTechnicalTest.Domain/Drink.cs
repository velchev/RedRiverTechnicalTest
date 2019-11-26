using System.Collections.Generic;

namespace RedRiverTechnicalTest.Domain
{
    public class Drink
    {
        private readonly List<string> _actions = new List<string>();

        public List<string> GetActionsPerformedDuringOperation()
        {
            return _actions;
        }

        public void AddAction(string steepTheWaterInTheTea)
        {
            _actions.Add(steepTheWaterInTheTea);
        }
    }
}