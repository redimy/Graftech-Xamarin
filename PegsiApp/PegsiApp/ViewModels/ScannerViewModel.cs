using GraftechApp.Dtos;
using PegsiApp.Helper;
using PegsiApp.Models;
using PegsiApp.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ZXing;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace PegsiApp.ViewModels
{
    public class ScannerViewModel : BaseViewModel
    {
        public INavigation Navigation { get; set; }

        public ICommand ScannerCommand { get; set; }
        public Color cGreen = Color.FromHex("#02a950");
        public Color cYellow = Color.FromHex("#fff200");
        public Color cRed = Color.Red;
        public string mActivo = "SIGA";
        public bool isvisible = false; 
        private DataService _dataService = new DataService();
        public ParticipanteDto _participanteDto;
        private List<String> _docVencidosList;

        private ICollection<CursosExternosDto> _cursosExternosDto;



        public ParticipanteDto _modelParticipante;
        public ParticipanteDto modelParticipante
        {
            get { return _modelParticipante; }
            set
            {
                _modelParticipante = value;
                OnPropertyChanged();
            }
        }


        public ParticipanteDto ParticipanteDto
        {
            get { return _participanteDto; }
            set
            {
                _participanteDto = value;
                OnPropertyChanged();
            }
        }

        public List<String> DocVencidosList
        {
            get { return _docVencidosList; }
            set
            {
                _docVencidosList = value;
                OnPropertyChanged();
            }
        }

        public ICollection<CursosExternosDto> CursosExternosDto
        {
            get { return _cursosExternosDto; }
            set
            {
                _cursosExternosDto = value;
                OnPropertyChanged();
            }
        }
        private string barcodeText;
        private string _fotoString;
        public string _colorMensaje;


        public string _info;
        public Color _colorS;
        public Color colorS
        {
            get => _colorS;
            set { _colorS = value; OnPropertyChanged(); }
        }
        public string ColorMensaje
        {
            get => _colorMensaje;
            set { _colorMensaje = value; OnPropertyChanged(); }
        }
        public string Info
        {
            get => _info;
            set { _info = value; OnPropertyChanged(); }
        }
        public string BarcodeText
        {
            get => barcodeText;
            set { barcodeText = value; OnPropertyChanged(); }
        }


        public string FotoString
        {
            get => _fotoString;
            set { _fotoString = value; OnPropertyChanged(); }
        }

        private BarcodeFormat _barcodeFormat;

        public string BarcodeFormat
        {
            get => BarcodeFormatConverter.ConvertEnumToString(_barcodeFormat);
            set
            {
                _barcodeFormat = (value != null)
                    ? BarcodeFormatConverter.ConvertStringToEnum(value)
                    : ZXing.BarcodeFormat.QR_CODE;
                OnPropertyChanged();
            }
        }

        public ScannerViewModel(INavigation navigation)
        {


            Navigation = navigation;
            FotoString = "Assets/user.png";
            Info = "Datos de la Persona:";
            colorS = cYellow;
            ScannerCommand = new Command(async () => await ScanCode());
        }

        private String urlImagenWeb(String clave, String nombreFoto)
        {
            String sSistema = new String(App.MindlinkUrl.Reverse().ToArray());
            String sUrlImagen = String.Format("https://{0}", sSistema);

            String resultado = String.Format("{0}/Uploads/Fotos/" + nombreFoto,
                sUrlImagen
            ).Replace("\r", String.Empty);

            return resultado;
        }
        async Task ScanCode()
        {
            var options = new MobileBarcodeScanningOptions();

            options.PossibleFormats = new List<BarcodeFormat>()
            {
                ZXing.BarcodeFormat.EAN_8,
                ZXing.BarcodeFormat.EAN_13,
                ZXing.BarcodeFormat.AZTEC,
                ZXing.BarcodeFormat.QR_CODE
            };

            var overlay = new ZXingDefaultOverlay
            {
                ShowFlashButton = false,
                TopText = "Coloca el código de barras frente al dispositivo",
                BottomText = "El escaneo es automático",
                Opacity = 0.75
            };
            overlay.BindingContext = overlay;

            var page = new ZXingScannerPage(options, overlay)
            {
                Title = "Escanear codigo de participante",
                DefaultOverlayShowFlashButton = true,
            };
            await Navigation.PushAsync(page);
            Info = "Cargando...";
            page.OnScanResult += (result) =>
            {
                page.IsScanning = false;

                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();

                    BarcodeText = result.Text;
                    ColorMensaje = "...";

                    string clave = BarcodeText.Split('/').LastOrDefault();
                    int iClave = 0;

                    try
                    {
                        iClave = Convert.ToInt32(clave);
                    }
                    catch (Exception ex)
                    {
                        BarcodeText = "Formato de clave inválido";
                        return;
                    }

                    try
                    {
                      
                        ParticipanteDto = await _dataService.GetParticipanteAsync(iClave);
                        if(ParticipanteDto != null && ParticipanteDto.EmpresaMasterId == 805)
                        {
                            modelParticipante = ParticipanteDto;
                        }
                        else
                        {
                            modelParticipante = null;
                        }
                        if (ParticipanteDto != null && (ParticipanteDto.EmpresaMasterId == 805))
                        {
                            DocVencidosList = ParticipanteDto.documentosVencidos;
                            CursosExternosDto = ParticipanteDto.CursosExternos;

                            var sImagenLocation = urlImagenWeb(clave, ParticipanteDto.Foto);

                            if (!File.Exists(sImagenLocation))
                            {
                                FotoString = new Uri(sImagenLocation).ToString();
                            }
                          

                            if (DocVencidosList.Count == 0)
                            {
                                //if (Participante.Credencial == true)
                                //{
                                //    colorS = cGreen;
                                //    ColorMensaje = mActivo;
                                //}
                                //else
                                //{
                                //    colorS = cRed;
                                //    ColorMensaje = "Inactivo";
                                //}
                                switch (ParticipanteDto.Estatus)
                                {
                                    case "Activo":
                                        colorS = cGreen;
                                        ColorMensaje = mActivo;
                                        break;
                                    case "Condicionado":
                                        colorS = cYellow;
                                        ColorMensaje = "Condicionado";
                                        break;
                                    case "Vetado":
                                        colorS = cRed;
                                        ColorMensaje = "Vetado";
                                        break;
                                    case null:
                                        colorS = cGreen;
                                        ColorMensaje = mActivo;
                                        break;
                        

                                }
                            }
                            else
                            {
                                colorS = cRed;
                                ColorMensaje = "ALTO";
                                barcodeText = "Documentos Vencidos";
                            }
                            Info = "Datos de la Persona:";
                        }
                        else
                        {
                            Info = "El usuario no existe";
                            colorS = cRed;
                            ColorMensaje = "ALTO";
     

                        }

                    }
                    catch (Exception ex)
                    {
                        barcodeText = "Sin conexión a internet.";
                        colorS = cRed;
                        ColorMensaje = "ALTO";
                    }

                    BarcodeFormat = BarcodeFormatConverter.ConvertEnumToString(result.BarcodeFormat);
                });
            };
        }
    }
}
