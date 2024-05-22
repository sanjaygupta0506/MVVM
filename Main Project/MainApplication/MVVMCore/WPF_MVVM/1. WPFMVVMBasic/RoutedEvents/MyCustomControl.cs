using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MainApplication.WPF_MVVM.WPFMVVMBasic.RoutedEvents
{
    class MyCustomControl : Control
    {
        static MyCustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyCustomControl), new FrameworkPropertyMetadata(typeof(MyCustomControl)));
        }

        /* Assign event handler to the Routed events here. Templates are the section of an element's 
        * completed visual tree that comes from the Template property of a Style that is applied for the element. 
        */
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            var custextblock = GetTemplateChild("tbCustomControl") as TextBlock;
            if (custextblock != null)
            {
                /* Assign mouse wheel event handler to the mouse wheel event. This is fired
                 * when the user rotates the mouse wheel while the cursor is on the control.
                 * */
                custextblock.MouseWheel += Custom_MouseWheel;
                /* Assign mouse down event handler to the mouse down event. This is fired
                 * when the user clicks any mouse button while the cursor is on the control.
                 * */
                custextblock.MouseDown += Custom_MouseClick;
            }
        }

        /* Event handler for mouse click */
        private void Custom_MouseClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            RaiseMouseClickEvent();
        }

        /* Event handler for mouse wheel rotate */
        void Custom_MouseWheel(object sender, RoutedEventArgs e)
        {
            RaiseMouseWheelEvent();
        }


        /***************** 1ST ROUTED EVENT ******************/
        /* Now we will create a custom routed event called CustomWheelEvent. The name of the event is MyCustomWheelRotate
         * Use bubbling strategy, handler type is RoutedEventHandler, Owner type is MyCustomControl.
         */
        public static readonly RoutedEvent CustomWheelEvent =
         EventManager.RegisterRoutedEvent("MyCustomWheelRotate", RoutingStrategy.Bubble,
         typeof(RoutedEventHandler), typeof(MyCustomControl));

        /* Just like Dependency Properties, routed events are also like wrapper over underlying RoutedEvent instance
         * and they wrap through a set of getter-setter methods.
         */
        public event RoutedEventHandler MyCustomWheelRotate
        {
            add { AddHandler(CustomWheelEvent, value); }
            remove { RemoveHandler(CustomWheelEvent, value); }
        }


        /***************** 2ND ROUTED EVENT ******************/
        /* Now we will create another custom routed event called CustomClickEvent. The name of the event is MyCustomClick
         * Use bubbling strategy, handler type is RoutedEventHandler, Owner type is MyCustomControl.
         */
        public static readonly RoutedEvent CustomClickEvent =
         EventManager.RegisterRoutedEvent("MyCustomClick", RoutingStrategy.Bubble,
         typeof(RoutedEventHandler), typeof(MyCustomControl));

        /* Just like Dependency Properties, routed events are also like wrapper over underlying RoutedEvent instance
         * and they wrap through a set of getter-setter methods.
         */
        public event RoutedEventHandler MyCustomClick
        {
            add { AddHandler(CustomClickEvent, value); }
            remove { RemoveHandler(CustomClickEvent, value); }
        }


        /* Raise the Mouse wheel routed event that travels through the element tree.
         */
        protected virtual void RaiseMouseWheelEvent()
        {
            RoutedEventArgs args = new RoutedEventArgs(CustomWheelEvent);
            RaiseEvent(args);
        }
        /* Raise the Mouse click routed event that travels through the element tree.
         */
        protected virtual void RaiseMouseClickEvent()
        {
            RoutedEventArgs args = new RoutedEventArgs(CustomClickEvent);
            RaiseEvent(args);
        }
    }
}
