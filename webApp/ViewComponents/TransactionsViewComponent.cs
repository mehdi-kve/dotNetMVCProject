﻿using Microsoft.AspNetCore.Mvc;
using UseCases;
using webApp.Models;

namespace webApp.ViewComponents
{
    [ViewComponent]
    public class TransactionsViewComponent : ViewComponent
    {
        private readonly IGetTodayTransactionsUseCase getTodayTransactionsUseCase;

        public TransactionsViewComponent(IGetTodayTransactionsUseCase getTodayTransactionsUseCase)
        {
            this.getTodayTransactionsUseCase = getTodayTransactionsUseCase;
        }

        public IViewComponentResult Invoke(string userName)
        {
            var transactions = getTodayTransactionsUseCase.Execute(userName);

            return View(transactions);
        }
    }
}
