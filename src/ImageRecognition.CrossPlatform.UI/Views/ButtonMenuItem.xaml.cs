using ImageRecognition.CrossPlatform.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageRecognition.CrossPlatform.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonMenuItem : Grid
    {
        public static readonly BindableProperty SourceProperty =
            BindableProperty.Create(nameof(Source), typeof(ImageSource), typeof(ButtonMenuItem), null,
                propertyChanged: (bindable, oldVal, newVal) =>
                {
                    var view = (ButtonMenuItem)bindable;
                    view.Image.Source = (ImageSource)newVal;
                });

        public static readonly BindableProperty CaptionProperty =
            BindableProperty.Create(nameof(Caption), typeof(string), typeof(ButtonMenuItem), string.Empty,
                propertyChanged: (bindable, oldVal, newVal) =>
                {
                    var view = (ButtonMenuItem)bindable;
                    view.Label.Text = (string)newVal;
                });

        public static readonly BindableProperty ButtonBackgroundColorProperty =
            BindableProperty.Create(nameof(ButtonBackgroundColor), typeof(Color), typeof(ButtonMenuItem), Color.Black,
                propertyChanged: (bindable, oldVal, newVal) =>
                {
                    var view = (ButtonMenuItem)bindable;
                    view.Frame.BackgroundColor = (Color)newVal;
                });

        public static readonly BindableProperty CaptionFontSizeProperty =
            BindableProperty.Create(nameof(CaptionFontSize), typeof(double), typeof(ButtonMenuItem), 9d,
                propertyChanged: (bindable, oldVal, newVal) =>
                {
                    var view = (ButtonMenuItem)bindable;
                    view.Label.FontSize = (double)newVal;
                });

        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(ButtonMenuItem));

        public static readonly BindableProperty CommandParameterProperty =
            BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(ButtonMenuItem));

        public static readonly BindableProperty ImageColorProperty =
            BindableProperty.Create(nameof(ImageColor), typeof(Color), typeof(ButtonMenuItem), Color.Black,
                propertyChanged: (bindable, oldVal, newVal) =>
                {
                    var view = (ButtonMenuItem)bindable;
                    var color = ((Color)newVal).GetHexString();
                    var changeColorDictionary = new Dictionary<string, string> { { "#fillColor", color } };
                    view.Image.ReplaceStringMap = changeColorDictionary;
                });

        private ICommand execCommand;

        public ButtonMenuItem()
        {
            InitializeComponent();
        }

        public ImageSource Source
        {
            get => (ImageSource)GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }

        public string Caption
        {
            get => (string)GetValue(CaptionProperty);
            set => SetValue(CaptionProperty, value);
        }

        public Color ButtonBackgroundColor
        {
            get => (Color)GetValue(ButtonBackgroundColorProperty);
            set => SetValue(ButtonBackgroundColorProperty, value);
        }

        public double CaptionFontSize
        {
            get => (double)GetValue(CaptionFontSizeProperty);
            set => SetValue(CaptionFontSizeProperty, value);
        }

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public object CommandParameter
        {
            get => GetValue(CommandParameterProperty);
            set => SetValue(CommandParameterProperty, value);
        }

        public Color ImageColor
        {
            get => (Color)GetValue(ImageColorProperty);
            set => SetValue(ImageColorProperty, value);
        }

        public ICommand ExecCommand
        {
            get
            {
                return execCommand
                       ?? (execCommand = new Command(async () =>
                       {
                           if (Command != null)
                           {
                               await this.ScaleTo(0.97, 50, Easing.Linear);
                               await Task.Delay(90);
                               await this.ScaleTo(1, 50, Easing.Linear);

                               Command.Execute(CommandParameter);
                           }
                       }));
            }
        }
    }
}