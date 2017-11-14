using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismCustomView.CustomViewCells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestEntryCell : ViewCell
    {
        public static readonly BindableProperty LabelProperty = BindableProperty.Create(
            propertyName: nameof(Label),
            returnType: typeof(string),
            declaringType: typeof(TestEntryCell));

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            propertyName: nameof(Text),
            returnType: typeof(string),
            declaringType: typeof(TestEntryCell),
            defaultBindingMode: BindingMode.TwoWay);

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public TestEntryCell()
        {
            InitializeComponent();
            /*So, after a lot of testing, I found out that if you set the BindingContext individually
             on each element like this, it works... The explanation for this is simple. A ViewCell
             is not like other containers (i.e StackLayout, Grid, etc) where setting the BindingContext
             to it will also be the same for the children, so, in this case (like happens with the
             ViewCells in ListViews) the elements inside have a different Binding ContextMy recommendation
             could be: As normally in these custom controls you have everything in a StackLayout or a Grid,
             you can set the BindingContext to 'this' on the Layout and let the children be binded
             to the same context. Like this (you can uncomment the following line and comment
             the other two, the result is the same:*/

            //myStack.BindingContext = this;
            myLabel.BindingContext = this;
            myText.BindingContext = this;
        }
    }
}