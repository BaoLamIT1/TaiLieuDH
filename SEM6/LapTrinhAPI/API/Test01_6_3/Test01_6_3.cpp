// Test01_6_3.cpp : Defines the entry point for the application.
//

#include "framework.h"
#include "Test01_6_3.h"
#include "math.h"

#define MAX_LOADSTRING 100

// Global Variables:
HINSTANCE hInst;                                // current instance
WCHAR szTitle[MAX_LOADSTRING];                  // The title bar text
WCHAR szWindowClass[MAX_LOADSTRING];            // the main window class name

// Forward declarations of functions included in this code module:
ATOM                MyRegisterClass(HINSTANCE hInstance);
BOOL                InitInstance(HINSTANCE, int);
LRESULT CALLBACK    WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK    About(HWND, UINT, WPARAM, LPARAM);

int APIENTRY wWinMain(_In_ HINSTANCE hInstance,
                     _In_opt_ HINSTANCE hPrevInstance,
                     _In_ LPWSTR    lpCmdLine,
                     _In_ int       nCmdShow)
{
    UNREFERENCED_PARAMETER(hPrevInstance);
    UNREFERENCED_PARAMETER(lpCmdLine);

    // TODO: Place code here.

    // Initialize global strings
    LoadStringW(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
    LoadStringW(hInstance, IDC_TEST0163, szWindowClass, MAX_LOADSTRING);
    MyRegisterClass(hInstance);

    // Perform application initialization:
    if (!InitInstance (hInstance, nCmdShow))
    {
        return FALSE;
    }

    HACCEL hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_TEST0163));

    MSG msg;

    // Main message loop:
    while (GetMessage(&msg, nullptr, 0, 0))
    {
        if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))
        {
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
    }

    return (int) msg.wParam;
}



//
//  FUNCTION: MyRegisterClass()
//
//  PURPOSE: Registers the window class.
//
ATOM MyRegisterClass(HINSTANCE hInstance)
{
    WNDCLASSEXW wcex;

    wcex.cbSize = sizeof(WNDCLASSEX);

    wcex.style          = CS_HREDRAW | CS_VREDRAW;
    wcex.lpfnWndProc    = WndProc;
    wcex.cbClsExtra     = 0;
    wcex.cbWndExtra     = 0;
    wcex.hInstance      = hInstance;
    wcex.hIcon          = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_TEST0163));
    wcex.hCursor        = LoadCursor(nullptr, IDC_ARROW);
    wcex.hbrBackground  = (HBRUSH)(COLOR_WINDOW+1);
    wcex.lpszMenuName   = MAKEINTRESOURCEW(IDR_MENU1);
    wcex.lpszClassName  = szWindowClass;
    wcex.hIconSm        = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

    return RegisterClassExW(&wcex);
}

//
//   FUNCTION: InitInstance(HINSTANCE, int)
//
//   PURPOSE: Saves instance handle and creates main window
//
//   COMMENTS:
//
//        In this function, we save the instance handle in a global variable and
//        create and display the main program window.
//
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
   hInst = hInstance; // Store instance handle in our global variable

   HWND hWnd = CreateWindowW(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,
      CW_USEDEFAULT, 0, CW_USEDEFAULT, 0, nullptr, nullptr, hInstance, nullptr);

   if (!hWnd)
   {
      return FALSE;
   }

   ShowWindow(hWnd, nCmdShow);
   UpdateWindow(hWnd);

   return TRUE;
}

//
//  FUNCTION: WndProc(HWND, UINT, WPARAM, LPARAM)
//
//  PURPOSE: Processes messages for the main window.
//
//  WM_COMMAND  - process the application menu
//  WM_PAINT    - Paint the main window
//  WM_DESTROY  - post a quit message and return
//
//

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
    static int width, height, xLeft, yTop, xRight, yBottom, HINH, m = 60 ,s= 0,count;
    static HPEN hpen = CreatePen(PS_SOLID,3, RGB(0, 0, 0)); // Luu but ve
    static int StylePen;
    static HBRUSH hbrush = (HBRUSH)GetStockObject(WHITE_BRUSH); // Color of HBrush
    static COLORREF colorPen, colorBrush;
    static HDC hdc;
    static POINT pt[3], point;
    static HMENU menuPen;
    static TCHAR leftTime[20];

    switch (message)
    {
        // Dong ho xuoi
    //case WM_CREATE:
    //    SetTimer(hWnd, 1, 1000, NULL);
    //    break;
    //case WM_SIZE:
    //    width = LOWORD(lParam);
    //    height = HIWORD(lParam);
    //    break;
    //case WM_TIMER:
    //    if (s >= 0 && s < 59)
    //    {
    //        s = s + 1;

    //    }
    //    else
    //    {
    //        if (s == 59)
    //        {
    //            s = 0;
    //            m = m + 1;
    //        }
    //    }
    //    wsprintf(leftTime, L"TIME: %d:%d", m, s);
    //    hdc = GetDC(hWnd);
    //    TextOut(hdc, width - 120, height - 20, leftTime, 20);
    //    ReleaseDC(hWnd, hdc);
    //    break;


        // Dong ho nguoc
    case WM_CREATE:
        SetTimer(hWnd, 1, 1000, NULL);
        break;
    case WM_SIZE:
        width = LOWORD(lParam);
        height = HIWORD(lParam);
        break;
    case WM_TIMER:
        if (s > 0 && s <=  59)
        {
            s = s - 1;

        }
        else
        {
            if (s == 0 && m > 0)
            {
                m = m - 1;s = 59;
            }
            if (s == 0 && m == 0)
            {
                KillTimer(hWnd, 0);
            }
        }
        wsprintf(leftTime, L"TIME: %d:%d", m, s);
        hdc = GetDC(hWnd);
        TextOut(hdc, width - 120, height - 20, leftTime, 20);
        ReleaseDC(hWnd, hdc);
        break;

    case WM_LBUTTONDOWN: // Nhan chuot trai lay toa do xLeft, yTop
        xLeft = LOWORD(lParam);
        yTop = HIWORD(lParam);
        break;
    case WM_LBUTTONUP:
        xRight = LOWORD(lParam);
        yBottom = HIWORD(lParam);
        hpen = CreatePen(StylePen, 1, colorPen);
        hbrush = CreateSolidBrush(colorBrush);
        
        // Ve hinh
        hdc = GetDC(hWnd);
        SelectObject(hdc, hpen);
        SelectObject(hdc, hbrush);

        if (HINH == ID_H_HCN)
        {
            Rectangle(hdc, xLeft, yTop, xRight, yBottom);
        }
        if (HINH == ID_H_HEART)
        {
       
        }
        if (HINH == ID_H_TRON)
        {
            int radius = (int)sqrt(pow(xRight - xLeft, 2) + pow(yBottom - yTop, 2)) / 2;
            int centerX = (xLeft + xRight) / 2;
            int centerY = (yTop + yBottom) / 2;

            // Draw the circle
            Ellipse(hdc, centerX - radius, centerY - radius, centerX + radius, centerY + radius);
        }

        if (HINH == ID_H_TGV)
        {
            pt[0].x = xLeft;
            pt[0].y = yTop;
            pt[1].x = xRight;
            pt[1].y = yBottom;
            pt[2].x = xLeft;
            pt[2].y = yBottom;
            Polygon(hdc, pt, 3);
        }
        if (HINH == ID_H_CHORD)
        {
            
            Chord(hdc, xLeft, yTop, xRight, yBottom, xLeft + (xRight + xLeft) / 2, yTop, xLeft, (yBottom + yTop) / 2);
        }
        if (HINH == ID_H_5GIAC)
        {
            //ngũ giác đều
            int radius = abs(xRight - xLeft) / 2;

            pt[0].x = (xLeft + xRight) / 2 + radius;
            pt[0].y = (yTop + yBottom) / 2;

            for (int i = 1; i <= 6; i++)
            {
                double angle = i * 2 * 3.14 / 5;
                pt[i].x = (xLeft + xRight) / 2 + radius * cos(angle);
                pt[i].y = (yTop + yBottom) / 2 - radius * sin(angle);
            }
            Polygon(hdc, pt, 5); 
        }
        if (HINH == ID_H_TGC)
        {
            pt[0].x = (xRight + xLeft) / 2;
            pt[0].y = yTop;
            pt[1].x = xLeft;
            pt[1].y = yBottom;
            pt[2].x = xRight;
            pt[2].y = yBottom;
            Polygon(hdc, pt, 3);
        }
        if (HINH == ID_H_STAR_4)
        {
            int xCenter = (xLeft + xRight) / 2; // Tọa độ x của tâm của hình ngôi sao
            int yCenter = (yTop + yBottom) / 2; // Tọa độ y của tâm của hình ngôi sao
            int radius = abs(xRight - xLeft)/2; // Bán kính của hình ngôi sao
            int numPoints = 4; // Số lượng đỉnh của hình ngôi sao

            POINT pt[11];

            for (int i = 0; i < numPoints * 2; i++)
            {
                double angle = i * 3.14 / numPoints - 3.14 / 2;
                if (i % 2 == 0) {
                    pt[i].x = xCenter + radius * cos(angle);
                    pt[i].y = yCenter + radius * sin(angle);
                }
                else {
                    pt[i].x = xCenter + (radius / 2) * cos(angle);
                    pt[i].y = yCenter + (radius / 2) * sin(angle);
                }
            }
            Polygon(hdc, pt, numPoints * 2);
        }
        if (HINH == ID_H_STAR5)
        {
            int xCenter = (xLeft + xRight) / 2; // Tọa độ x của tâm của hình ngôi sao
            int yCenter = (yTop + yBottom) / 2; // Tọa độ y của tâm của hình ngôi sao
            int radius = abs(xRight - xLeft) / 2; // Bán kính của hình ngôi sao
            int numPoints = 5; // Số lượng đỉnh của hình ngôi sao

            POINT pt[11];

            for (int i = 0; i < numPoints * 2; i++)
            {
                double angle = i * 3.14 / numPoints - 3.14 / 2;
                if (i % 2 == 0) {
                    pt[i].x = xCenter + radius * cos(angle);
                    pt[i].y = yCenter + radius * sin(angle);
                }
                else {
                    pt[i].x = xCenter + (radius / 2) * cos(angle);
                    pt[i].y = yCenter + (radius / 2) * sin(angle);
                }
            }
            Polygon(hdc, pt, numPoints * 2);
        }
    

        ReleaseDC(hWnd, hdc);
        break;




    case WM_COMMAND:
        {
               
            int wmId = LOWORD(wParam);
            // Parse the menu selections:
            switch (wmId)
            {
            case ID_H_HCN:
            case ID_H_TGV:
            case ID_H_CHORD:
            case ID_H_TGC:
            case ID_H_STAR_4:
            case ID_H_STAR5:
            case ID_H_5GIAC:
            case ID_H_HEART:
            case ID_H_TRON:
                HINH = wmId;
                break;
                // Mau Vien
            case ID_M_RED:
                colorPen = RGB(255, 0, 0);
                break;
            case ID_M_YELLOW:
                colorPen = RGB(255, 255, 0);
                break;

            case ID_NEN_GREEN:
                colorBrush = RGB(0, 128, 0);
                break;

            case ID_NEN_BLUE:
                colorBrush = RGB(0, 0, 255);
                break;
            case ID_NEN_PURPLE:
                colorBrush = RGB(238, 130, 238);
                break;

            case ID_KV_NETDUT:
                StylePen = PS_DOT;
                break;
            case ID_KV_NETLIEN:
                StylePen = PS_DASH;
                break;
               


            case IDM_ABOUT:
                DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
                break;
            case IDM_EXIT:
                DestroyWindow(hWnd);
                break;
            case ID_H_EXIT:
                if (MessageBox(NULL, TEXT("Do you want to exit ?"), TEXT("YES or NO")
                    , MB_YESNO | MB_ICONQUESTION) == IDYES) PostQuitMessage(0);
                break;
            default:
                return DefWindowProc(hWnd, message, wParam, lParam);
            }
        }
        break;
    case WM_PAINT:
        {
            PAINTSTRUCT ps;
            HDC hdc = BeginPaint(hWnd, &ps);
            // TODO: Add any drawing code that uses hdc here...
            EndPaint(hWnd, &ps);
        }
        break;
    case WM_DESTROY:
        PostQuitMessage(0);
        break;
    default:
        return DefWindowProc(hWnd, message, wParam, lParam);
    }
    return 0;
}

// Message handler for about box.
INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {
    case WM_INITDIALOG:
        return (INT_PTR)TRUE;

    case WM_COMMAND:
        if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
        {
            EndDialog(hDlg, LOWORD(wParam));
            return (INT_PTR)TRUE;
        }
        break;
    }
    return (INT_PTR)FALSE;
}
