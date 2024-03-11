using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM.SOLID_Princliple.Models
{
    //#region MyRegion
    //public interface IDocument
    //{
    //    void Create();
    //    void Open();
    //    void Save();
    //}
    //class LSP_TextDocument : IDocument
    //{
    //    public void Create()
    //    {
    //        //throw new NotImplementedException();
    //    }

    //    public void Open()
    //    {
    //        //throw new NotImplementedException();
    //    }

    //    public void Save()
    //    {
    //        //throw new NotImplementedException();
    //    }
    //}

    //#endregion

    #region Interface Segregation Principle (ISP)
    public interface ICreateDocument
    {
        void Create();
    }

    public interface IOpenDocument
    {
        void Open();
    }

    public interface ISaveDocument
    {
        void Save();
    }

    public class TextDocument : ICreateDocument, IOpenDocument, ISaveDocument
    {
        public void Create()
        {
            // Create text document
        }

        public void Open()
        {
            // Open text document
        }

        public void Save()
        {
            // Save text document
        }
    }

    public class SpreadsheetDocument : ICreateDocument, IOpenDocument, ISaveDocument
    {
        public void Create()
        {
            // Create spreadsheet document
        }

        public void Open()
        {
            // Open spreadsheet document
        }

        public void Save()
        {
            // Save spreadsheet document
        }
    }
    #endregion

}
