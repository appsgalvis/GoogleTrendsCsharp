using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using RestSharp;
using Newtonsoft.Json;





/*  ######################################## - DemoGoogleTrends - ########################################
	
	
	# tema : Acceso a datos de Google Trends desde Windows Forms
	# autor: Cristian Johan Galvis Bernal
	# fecha: 06/12/2022

	Dependencias 

		 *  Net Framework 4.6
		 *  Newtonsoft.Json
		 *  RestSharp


*/

namespace DemoGoogleTrends
{
    public partial class DemoGoogleTrends : Form
    {



        public DemoGoogleTrends()
        {
            InitializeComponent();
        }





        public async void botonGenerarGrafico_Click(object sender, EventArgs e)
        {


            
            if (textoGoogle.Text != "" && territorioGoogle.Text != "" && tiempoGoogle.Text != "")
            {

                grafico.ChartAreas[0].AxisY.Maximum = 100;
                grafico.ChartAreas[0].AxisY.Minimum = 0;

                string geo ;

                if (territorioGoogle.Text == "NACIONAL") { geo = "CO"; } else { geo = ""; }

               // TrendsSolicitud solicitud = new TrendsSolicitud(textoGoogle.Text, geo, TrendsUtility.T7_DIA);
                TrendsSolicitud solicitud = new TrendsSolicitud(textoGoogle.Text, geo,"now "+tiempoGoogle.Text);
                TrendsRespondSolicitud RespondSolicitud = new TrendsUtility().getTrendsRespondSolicitud(solicitud);

                if (territorioGoogle.Text == "NACIONAL")
                {
                    if (tiempoGoogle.Text == "1-d")
                    {
                        grafico.ChartAreas[0].AxisX.LabelStyle.Interval = 14;
                        grafico.Titles[0].Text = RespondSolicitud.widgets[0].title + " tendencia de " + textoGoogle.Text + " las ultimas 24 horas.";
                    }
                    if (tiempoGoogle.Text == "7-d")
                    {
                        grafico.ChartAreas[0].AxisX.LabelStyle.Interval = 24;
                        grafico.Titles[0].Text = RespondSolicitud.widgets[0].title + " tendencia de " + textoGoogle.Text + " los ultimos 7 dias.";
                    }
               


                    TrendsGetDataGrafica getDataGrafica = new TrendsGetDataGrafica( RespondSolicitud);
                    updateChart(getDataGrafica.getTrendsJsonResponse(), SeriesChartType.Line);




                }///if (territorioGoogle.Text == "NACIONAL")
                else
                {


                    if (tiempoGoogle.Text == "1-d")
                    {
                        grafico.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                        grafico.Titles[0].Text = RespondSolicitud.widgets[1].title + " tendencia de " + textoGoogle.Text + " las ultimas 24 horas.";
                    }
                    if (tiempoGoogle.Text == "7-d")
                    {
                        grafico.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                        grafico.Titles[0].Text = RespondSolicitud.widgets[1].title + " tendencia de " + textoGoogle.Text + " los ultimos 7 dias.";
                    }
                    


                    TrendsGetDataMapa getdatamapa = new TrendsGetDataMapa( RespondSolicitud);
                    updateChart(getdatamapa.getTrendsJsonResponse(), SeriesChartType.Column);


                }/// internacional


            }
            else
            {


                MessageBox.Show("Falta el texto de busqueda.. o alguna de las demas varibles.");



            }


        }



        public void updateChart(TrendsJsonResponse data, SeriesChartType tipo)
        {
            grafico.Series[0].Points.Clear();
            grafico.Series[0].ChartType = tipo;

            switch (tipo)
            {

                case SeriesChartType.Line:

                    foreach (TrendsJsonResponse.TimelineDatum gm in data.@default.timelineData)
                    {
                                int index = grafico.Series[0].Points.AddXY(gm.formattedAxisTime, gm.value[0]);

                                if (tiempoGoogle.Text == "1-d")
                                {
                                    grafico.Series[0].Points[index].AxisLabel = gm.formattedAxisTime;
                                }
                                else
                                {
                                    grafico.Series[0].Points[index].AxisLabel = gm.formattedAxisTime;

                                } 

                    }
                    grafico.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
                    break;


                case SeriesChartType.Column:
                    foreach (TrendsJsonResponse.GeoMapDatum gm in data.@default.geoMapData)
                    {
                            if (gm.geoName != "" && gm.value[0] >= 15)
                            {
                                int index = grafico.Series[0].Points.AddXY(gm.geoName, gm.value[0]);
                                Console.WriteLine(gm.geoName+" -- "+ gm.value[0]);
                            }
                    }
                    grafico.ChartAreas[0].AxisX.LabelStyle.Angle = 45; 
                    break;

            }
        }

    }



    
}
