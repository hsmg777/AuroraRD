using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AuroraRD.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AuroraRD.Controllers
{
    public class IngresoFiestas : Controller
    {
        // GET: IngresoFiestas
        public ActionResult Index()
        {
            return View();
        }

        // GET: IngresoFiestas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IngresoFiestas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IngresoFiestas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Rootobject model) // Cambiado el nombre del parámetro a 'model'
        {
            try
            {
                // Realizar la solicitud POST a la API
                using (HttpClient client = new HttpClient())
                {
                    // Reemplazar la URL con la dirección correcta de tu API
                    string apiUrl = "https://localhost:7051/api/Fiestas";

                    // Convertir el modelo a formato JSON
                    string jsonModel = JsonConvert.SerializeObject(model);

                    // Configurar el contenido de la solicitud
                    HttpContent content = new StringContent(jsonModel, Encoding.UTF8, "application/json");

                    // Realizar la solicitud POST
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Puedes realizar alguna acción adicional si es necesario

                        // Redirigir a la acción Index
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        // Manejar el caso en que la solicitud no fue exitosa
                        ModelState.AddModelError(string.Empty, "Error al guardar en la API");
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones si es necesario
                ModelState.AddModelError(string.Empty, "Error: " + ex.Message);
            }

            // En caso de error, volver a la vista
            return View();
        }

        // GET: IngresoFiestas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IngresoFiestas/Edit/5
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

        // GET: IngresoFiestas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IngresoFiestas/Delete/5
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

        // GET: IngresoFiestas/View
        public ActionResult View()
        {

            return View("~/Views/Fiestas/View.cshtml");
        }
    }
}


