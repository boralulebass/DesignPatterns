namespace DesignPattern.IteratorPattern.IteratorPattern
{
    public class VisitRouteMover : IMover<VisitRoute>
    {
        public List<VisitRoute> visitRoutes = new List<VisitRoute>();
        public void AddVisitRoute(VisitRoute route)
        {
            visitRoutes.Add(route);
        }
        public int VisitRouteCount { get => visitRoutes.Count; }
        public Iterator<VisitRoute> CreateIterator()
        {
            return new VisitRouteIterator(this);
        }
    }
}
