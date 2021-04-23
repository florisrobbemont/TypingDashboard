using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using TypingDashboard.Typings.Dto;

namespace TypingDashboard.Typings
{
    public interface ITypingAppService : IAsyncCrudAppService<TypingDto, int, PagedTypingResultRequestDto, CreateTypingDto, TypingDto>
    {
    }
}
