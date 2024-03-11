using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM.SOLID_Princliple.Models
{
    //#region Normal Functionality
    //public class Shape
    //{
    //    public virtual void Draw()
    //    {
    //        //Draw shape on the screen
    //    }
    //}

    //public class Rectangle : Shape
    //{
    //    public override void Draw()
    //    {
    //        //Draw rectangle on the screen
    //    }
    //}

    //public class Circle : Shape
    //{
    //    public override void Draw()
    //    {
    //        //Draw circle on the screen
    //    }
    //}
    //#endregion

    #region Open-Closed Principle(OCP)
    public interface IShape
    {
        void Draw();
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            // Draw rectangle on the screen
        }
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            // Draw circle on the screen
        }
    }

    public class Triangle : IShape
    {
        public void Draw()
        {
            // Draw triangle on the screen
        }
    }
    #endregion

}
