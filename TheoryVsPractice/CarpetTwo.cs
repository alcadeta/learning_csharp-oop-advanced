using System.Collections.Generic;

namespace TheoryVsPractice
{
    /// <summary>
    /// Even a better approach than implementing multiple interfaces is
    /// composition. Composition is both a more robust and a more flexible
    /// approach to allowing only certain instances of a class to have certain
    /// properties and/or methods.
    /// </summary>

    public class CarpetTwo
    {
        public List<IAction> Actions { get; private set; } = new List<IAction>();

        public CarpetTwo(params IAction[] possibleActions) =>
            Actions.AddRange(possibleActions);
    }

    public interface IAction
    {
        void PerformAction();
    }

    public class Sweepable : IAction
    {
        public void PerformAction() => Sweep();
        private void Sweep() { }
    }

    public class ArtExhibit : IAction
    {
        public void PerformAction() => Exhibit();
        private void Exhibit() { }
    }
}