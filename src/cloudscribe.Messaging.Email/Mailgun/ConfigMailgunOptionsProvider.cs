﻿using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace cloudscribe.Messaging.Email.Mailgun
{
    public class ConfigMailgunOptionsProvider : IMailgunOptionsProvider
    {
        public ConfigMailgunOptionsProvider(IOptions<MailgunOptions> optionsAccessor)
        {
            _options = optionsAccessor.Value;
        }

        private MailgunOptions _options;

        public Task<MailgunOptions> GetMailgunOptions()
        {
            return Task.FromResult(_options);
        }


    }
}
