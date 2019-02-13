using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeLib;

/*
 *  License : Apache-2.0 license
 *  해당 라이브러리 프로젝트 주소 
 *  https://github.com/barnhill/barcodelib
 *  
 */
namespace MiniERP.VO
{
    class Barcode_Module
    {
        /// <summary>
        /// 바코드 이미지생성함
        /// </summary>
        /// <param name="bacodeValue">바코드 값</param>
        /// <param name="lblChk">바코드에 코드번호 스위치</param>
        /// <param name="size">바코드 사이즈</param>
        /// <returns>바코드 이미지를 반환</returns>
        public Image MakeBarcode(string bacodeValue,bool lblChk,Size size)
        {
            Debug.WriteLine("bacode : MakeBarcode is running");

            Barcode code = new Barcode();
            Image barcode_img;

            if (String.IsNullOrEmpty(bacodeValue))  //  바코드값이 널일경우
            {
                Debug.WriteLine("err_bacode : bacodeValue is null or empty");
                return null;
            }

            if (lblChk != false)                    //  바코드 라벨
            {
                code.IncludeLabel = lblChk;
                code.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER;
            }

            try
            {
                code.RawData = bacodeValue;             //  바코드 정보
                code.Encode(TYPE.CODE128, bacodeValue, Color.Black, Color.White, size.Width, size.Height);
            }
            catch (Exception)
            {
                Debug.WriteLine("err_bacode : bacode Encoding Exception");
                throw;
            }

            barcode_img = code.EncodedImage;
            Debug.WriteLine("bacode : bacode image make finish");

            return barcode_img;
        }
        
    }
    
}
