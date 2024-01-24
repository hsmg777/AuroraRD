using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AuroraRD.Models;
using System.Collections.ObjectModel;

namespace AuroraRD.Controllers
{
    public class VerReservita : Controller
    {
        private readonly HttpClient _httpClient;

        public VerReservita()
        {
            _httpClient = new HttpClient();
        }

        // GET: VerReservita/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VerReservita/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VerReservita/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VerReservita/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VerReservita/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VerReservita/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VerReservita/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VerReservita/View
        public async Task<ActionResult> Views()
        {
            await LoadReservasAsync(); // Llamar al método de carga de reservas
            return View("~/Views/Reservas/View.cshtml", Reservas.ToList());
        }

        private ObservableCollection<Class1> Reservas { get; set; } = new ObservableCollection<Class1>();

        private async Task LoadReservasAsync()
        {
            try
            {
                string apiUrl = "https://localhost:7051/api/Reservas";

                var response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Content.ReadAsStringAsync();
                    var reservasList = JsonConvert.DeserializeObject<List<Class1>>(jsonContent);


                    Reservas = new ObservableCollection<Class1>(reservasList);
                }
                else
                {
                    Console.WriteLine("Error al obtener las reservas. Código de estado: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}

