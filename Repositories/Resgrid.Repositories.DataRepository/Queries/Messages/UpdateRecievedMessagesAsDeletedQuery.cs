﻿using Resgrid.Model;
using Resgrid.Model.Repositories.Queries.Contracts;
using Resgrid.Repositories.DataRepository.Configs;
using Resgrid.Repositories.DataRepository.Extensions;

namespace Resgrid.Repositories.DataRepository.Queries.Messages
{
	public class UpdateRecievedMessagesAsDeletedQuery : ISelectQuery
	{
		private readonly SqlConfiguration _sqlConfiguration;
		public UpdateRecievedMessagesAsDeletedQuery(SqlConfiguration sqlConfiguration)
		{
			_sqlConfiguration = sqlConfiguration;
		}

		public string GetQuery()
		{
			var query = _sqlConfiguration.UpdateRecievedMessagesAsDeletedQuery
				.ReplaceQueryParameters(_sqlConfiguration.SchemaName,
					_sqlConfiguration.MessageRecipientsTable,
					_sqlConfiguration.ParameterNotation,
					new string[] { "%USERID%" },
					new string[] { "UserId" });

			return query;
		}

		public string GetQuery<TEntity>() where TEntity : class, IEntity
		{
			throw new System.NotImplementedException();
		}
	}
}
