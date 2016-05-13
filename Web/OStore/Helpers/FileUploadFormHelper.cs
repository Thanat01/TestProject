namespace System.Web.Mvc
{
    public static class FileUploadFormHelper
    {
        public static MvcHtmlString FileUploadForm(this HtmlHelper htmlHelper, string ControllerAction)
        {
            string formTemplate = @"<div action='{0}' method='post' enctype='multipart/form-data' class='dropzone'  id='dropzoneForm'  style='width:100%;'>
                                        <div class='fallback'>
                                            <input name='file' type='file' multiple />
                                            <input type='submit' value='Upload' />
                                        </div>
                                    </div>";
            return new MvcHtmlString(string.Format(formTemplate, ControllerAction)); ;
        }
    }
}