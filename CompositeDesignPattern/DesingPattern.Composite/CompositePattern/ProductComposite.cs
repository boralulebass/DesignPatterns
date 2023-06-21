using System.Text;

namespace DesingPattern.Composite.CompositePattern
{
    public class ProductComposite : IComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private List<IComponent> _component;

        public ProductComposite(int id, string name)
        {
            Id = id;
            Name = name;
            _component = new List<IComponent>();
        }

        public ICollection<IComponent> Components => _component;
        public void Add(IComponent component)
        {
            _component.Add(component);
        }
        public string Display()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"<div class='text-success'>{Name} ({TotalCount()})</div>");
            stringBuilder.Append("<ul class='list-group list-group-flush ms-2'>");
            foreach (var item in _component)
            {
                stringBuilder.Append(item.Display());
            }
            stringBuilder.Append("</ul>");
            return stringBuilder.ToString();
        }

        public int TotalCount()
        {
            return _component.Sum(x=>x.TotalCount());
        }
    }
}
