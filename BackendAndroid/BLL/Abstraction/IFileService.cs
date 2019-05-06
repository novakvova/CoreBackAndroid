using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAndroid.BLL.Abstraction
{
    public interface IFileService
    {
        string UploadImage(string base64);
    }
}
