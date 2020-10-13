using System;
using System.Collections.Generic;
using System.Linq;
using DealTrackAPI.Entities;
using DealTrackAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DealTrackAPI.Repositories
{
    public class DealRepository : IDealRepository
    {
        private readonly DealTrackDBContext _context;
        public DealRepository(DealTrackDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void CreateDeal(Deal deal)
        {
            _context.Deals.Add(deal);
        }

        public void DeleteDeal(int dealId)
        {
            throw new NotImplementedException();
        }

        public Deal GetDeal(int dealId)
        {
            var deal = new Deal();
            //deal = _context.Deals.Where(i => i.Id == dealId).FirstOrDefault();
            //deal.DealAppraiser = _context.Appraisers.Where(a => a.Id == deal.AppraiserId).FirstOrDefault();
            //deal.DealLender = _context.Lenders.Where(l => l.Id == deal.LenderID).FirstOrDefault();
            //deal.DealProperty = _context.Properties.Where(p => p.Id == deal.PropertyId).FirstOrDefault();
            //deal.DealAssignee = _context.Users.Where(u => u.Id == deal.AssigneeId).FirstOrDefault();
            //deal.DealCreator = _context.Users.Where(u => u.Id == deal.CreatorId).FirstOrDefault();
            //deal.Comments = _context.Comments.Where(c => c.DealId == deal.Id).ToList();
            //deal.DealTitleCompany = _context.TitleCompanies.Where(t => t.Id == deal.TitleCompanyId).FirstOrDefault();
            //deal.CustomerDeals = _context.CustomerDeals.Where(cd => cd.DealId == deal.Id).ToList();
            deal = _context.Deals.Include(a => a.DealAppraiser)
                .Include(l => l.DealLender)
                .Include(p => p.DealProperty)
                .Include(a => a.DealAssignee)
                .Include(c => c.DealCreator)
                .Include(c => c.Comments)
                .Include(t => t.DealTitleCompany)
                .Include(cd => cd.CustomerDeals)
                .Where(i => i.Id == dealId).FirstOrDefault();
            return deal;
        }

        public IEnumerable<DealDTO> GetDeals()
        {
            throw new NotImplementedException();
        }

        public void UpdateDeal(DealDTO deal)
        {
            throw new NotImplementedException();
        }
    }
}
