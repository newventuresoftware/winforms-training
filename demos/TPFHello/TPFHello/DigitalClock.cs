using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;

namespace TPFHello
{
    [ToolboxItem(true)]
    public class DigitalClock : RadControl
    {
        private DigitalClockElement clockElement;
        public DigitalClock()
        {
            this.AutoSize = true;
        }

        public DigitalClockElement ClockElement => this.clockElement;
        public bool Active => this.clockElement.Active;
        protected override Size DefaultSize => new Size(200, 100);

        protected override void CreateChildItems(RadElement parent)
        {
            this.clockElement = new DigitalClockElement();
            this.clockElement.Start();
            this.RootElement.Children.Add(clockElement);

            base.CreateChildItems(parent);
        }
    }

    public class DigitalClockElement : RadElement
    {
        public static RadProperty CurrentTimeProperty = RadProperty.Register("CurrentTime",
            typeof(string), typeof(DigitalClockElement),
            new RadElementPropertyMetadata(null, ElementPropertyOptions.AffectsDisplay));

        private TextPrimitive text;
        private FillPrimitive background;
        private BorderPrimitive border;
        private Timer updateTime;

        public bool Active => updateTime.Enabled;

        public string CurrentTime
        {
            get { return (string)this.GetValue(CurrentTimeProperty); }
            set { this.SetValue(CurrentTimeProperty, value); }
        }

        public void Start()
        {
            this.updateTime.Start();
        }

        public void Stop()
        {
            this.updateTime.Stop();
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.background = new FillPrimitive();
            this.Children.Add(this.background);

            this.text = new TextPrimitive();
            this.text.Margin = new Padding(10);
            this.text.BindProperty(TextPrimitive.TextProperty, this,
                DigitalClockElement.CurrentTimeProperty, PropertyBindingOptions.OneWay);
            this.Children.Add(this.text);

            this.border = new BorderPrimitive();
            this.Children.Add(this.border);

            updateTime = new Timer();
            updateTime.Interval = 100;
            updateTime.Tick += new EventHandler(OnTimerTick);
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            this.SetValue(CurrentTimeProperty, DateTime.Now.ToString("T"));
        }
    }
}
