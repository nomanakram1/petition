using Microsoft.EntityFrameworkCore;
using petition.Models;
using petition.Models.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.DataLayer
{
    public interface IUserRolesDL
    {
        Task<UserRole> InsertUserRole(UserRole model);
        Task<bool> DeleteRole(string roleId, string userId);
        Task<bool> DeleteRolesByUserId(string userId);
        Task<List<UserRole>> GetUserRoleList(string userId);
    }
    public class UserRolesDL : IUserRolesDL
    {
        private readonly AppDbContext context;
        public UserRolesDL(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> DeleteRole(string roleId, string userId)
        {
            var role = context.userRoles.Where(r => r.userId == userId && r.roleId == roleId);
            context.userRoles.RemoveRange(role);
            context.SaveChanges();
            return true;
        }
        public async Task<bool> DeleteRolesByUserId(string userId)
        {
            var role = context.userRoles.Where(r => r.userId == userId);
            context.userRoles.RemoveRange(role);
            context.SaveChanges();
            return true;
        }

        public async Task<List<UserRole>> GetUserRoleList(string userId)
        {
            var details = await context.userRoles.Where(a =>a.userId == userId).ToListAsync();
            return details;
        }

        public async Task<UserRole> InsertUserRole(UserRole model)
        {
            await context.userRoles.AddAsync(model);
            await context.SaveChangesAsync();
            return model;
        }
    }
}
