using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismCustomView.CustomViewCells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestEntryCell : ViewCell
    {
        public static BindableProperty LabelProperty = BindableProperty.Create(
            propertyName: nameof(Label),
            returnType: typeof(string),
            declaringType: typeof(TestEntryCell),
            defaultValue: null,
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: OnLabelChanged);

        private static void OnLabelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var myview = bindable as TestEntryCell;
            myview.myLabel.Text = newValue as string;
        }

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public static BindableProperty TextProperty = BindableProperty.Create(
          propertyName: nameof(Text),
          returnType: typeof(string),
          declaringType: typeof(TestEntryCell),
          defaultValue: null,
          defaultBindingMode: BindingMode.TwoWay,
          propertyChanged: OnTextChanged);

        private static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var myview = bindable as TestEntryCell;
            myview.myText.Text = newValue as string;
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public TestEntryCell()
        {
            InitializeComponent();

            //BindingContext = this;
        }
    }
}