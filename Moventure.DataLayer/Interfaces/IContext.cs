﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Deventure.DataLayer.Interfaces
{
    public interface IContext
    {
        void SetLazyLoadingEnabled(bool enabled);

        IEnumerable<T> ExecuteStoredProcedure<T>(object storedProcedure);

        void Dispose();

        Task<int> SaveChangesAsync();

        int SaveChanges();

        void SetState<T>(T item, int state) where T : class;

        int GetState<T>(T item) where T : class;

        void SetAutoDetectChanges(bool autoDetectChanges);

        bool IsTransactionContextInvalid();

        void CommitTransactionContext();

        void RollbackTransactionContext();

        void BeginTransaction();

        void DisposeTransactionContext();
    }
}