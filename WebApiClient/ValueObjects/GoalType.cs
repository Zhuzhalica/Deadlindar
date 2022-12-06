using System.Drawing;

namespace WebApiClient
{
    public class GoalType
    {
        public string Title { get; private set; }
        public Color Color { get; private set; }

        public GoalType(string title, Color color)
        {
            this.Title = title;
            this.Color = color;
        }

        public void ChangeColor(Color color)
        {
            Color = color;
        }
        
        
        public void ChangeTitle(string title)
        {
            this.Title = title;
        }
    }
}