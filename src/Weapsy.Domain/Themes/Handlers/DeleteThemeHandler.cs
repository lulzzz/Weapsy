using System;
using System.Collections.Generic;
using Weapsy.Domain.Themes.Commands;
using Weapsy.Infrastructure.Commands;
using Weapsy.Infrastructure.Events;

namespace Weapsy.Domain.Themes.Handlers
{
    public class DeleteThemeHandler : ICommandHandler<DeleteTheme>
    {
        private readonly IThemeRepository _themeRepository;

        public DeleteThemeHandler(IThemeRepository themeRepository)
        {
            _themeRepository = themeRepository;
        }

        public IEnumerable<IEvent> Handle(DeleteTheme command)
        {
            var theme = _themeRepository.GetById(command.Id);

            if (theme == null)
                throw new Exception("Theme not found.");

            theme.Delete();

            _themeRepository.Update(theme);

            return theme.Events;
        }
    }
}
