using System;
using System.Collections.Generic;
using Domain.Models;

namespace Repository.Interfaces 
{

    /// <summary>
    /// This is the Interface for the User Repository.
    /// It contains the methods that the Repo must
    /// implement, which are based on CRUD operations.
    /// Each main class of the programm will have its own
    /// interface and respective repo class.
    /// These will implement the IDisposable interface
    /// since using database context is unmanaged.
    /// </summary>
    public interface IUserRepository : IDisposable
    {

        /// <summary>
        /// Create User
        /// </summary>
        void InsertUser(User user);

        /// <summary>
        /// Read all users
        /// </summary>
        ICollection<User> GetAllUsers();

        /// <summary>
        /// Update a user
        /// </summary>
        void UpdateUser(User user);

        /// <summary>
        /// Delete a user
        /// </summary>
        void DeleteUser(int userId);

        /// <summary>
        /// Save changes
        /// </summary>
        void Save();

    }
}