using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{

    public interface IFileProcess
    {
        Task<IResult> Upload(string fileName, IFormFile formFile);
        IResult Delete(string path);
    }
}
