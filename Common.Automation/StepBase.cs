using Common.Automation.ElementActions.Elements;

namespace Common.Automation
{
    public class StepBase
    {
        public Button Button => DriverHolder.CreateObject<Button>();
        public Input Input => DriverHolder.CreateObject<Input>();
        public TextElement TextElement => DriverHolder.CreateObject<TextElement>();
        public Dropdown Dropdown => DriverHolder.CreateObject<Dropdown>();
        public Navigation Navigation => DriverHolder.CreateObject<Navigation>();
    }
}
