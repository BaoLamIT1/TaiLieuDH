// de1_eclip.cpp : Defines the entry point for the application.
//

#include "framework.h"
#include "de1_eclip.h"
#include <math.h>

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
    LoadStringW(hInstance, IDC_DE1ECLIP, szWindowClass, MAX_LOADSTRING);
    MyRegisterClass(hInstance);

    // Perform application initialization:
    if (!InitInstance (hInstance, nCmdShow))
    {
        return FALSE;
    }

    HACCEL hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_DE1ECLIP));

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
    wcex.hIcon          = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_SMALL));
    wcex.hCursor        = LoadCursor(hInstance, MAKEINTRESOURCE(IDC_MT));
    wcex.hbrBackground  = (HBRUSH)(COLOR_WINDOW+1);
    wcex.lpszMenuName   = MAKEINTRESOURCEW(130);
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

   HWND hWnd = CreateWindowW(szWindowClass, TEXT("Vẽ hình"), WS_OVERLAPPEDWINDOW,
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
    static int width, height, xLeft, yTop, xRight, yBottom, Hinh, m = 60, s = 0;
    static HBRUSH hbrush = (HBRUSH)GetStockObject(WHITE_BRUSH); 
    static HPEN hpen = CreatePen(PS_SOLID, 3, RGB(255, 0, 0)); 
    static COLORREF currentColor= RGB(255, 255, 255); 
    static HDC hdc; 
    static POINT pt[100], point;
    static TCHAR leftTime[20];
    static int currentHatchBrush = -1; 

    switch (message)
    {
    case WM_CREATE:
        SetTimer(hWnd, 1, 1000, NULL);
        break;
    case WM_SIZE:
        width = LOWORD(lParam);
        height = HIWORD(lParam);
        break;
    case WM_TIMER:
        if (s > 0 && s <= 59)
        {
            s = s - 1;
        }
        else {
            if (s == 0 && m > 0)
            {
                m = m - 1;
                s = 59;
            }
            if (s == 0 && m == 0)
            {
                KillTimer(hWnd, 1);
            }
        }
        wsprintf(leftTime, L"Time: %d:%d", m, s);
        hdc = GetDC(hWnd);
        TextOut(hdc, width - 120, height - 20, leftTime, 20);
        ReleaseDC(hWnd, hdc);
        break;
    case WM_LBUTTONDOWN:
        xLeft = LOWORD(lParam);
        yTop = HIWORD(lParam);
        break;

    case WM_LBUTTONUP:
        xRight = LOWORD(lParam);
        yBottom = HIWORD(lParam);
        // vẽ hình
        hdc = GetDC(hWnd);
        if (currentHatchBrush == -1)  {
            DeleteObject(SelectObject(hdc, CreateSolidBrush(currentColor)));
        }
        else {
            DeleteObject(SelectObject(hdc, CreateHatchBrush(currentHatchBrush, currentColor)));
        }
        
        SelectObject(hdc, hpen); 
        //SelectObject(hdc, hbrush);
       
       
        if (Hinh == ID_HT)
        { // hình thoi
            pt[0].x = xLeft; 
            pt[0].y = yTop; 
            pt[1].x = xRight; 
            pt[1].y = (yBottom+yTop)/2; 
            pt[2].x = xLeft; 
            pt[2].y = yBottom; 
            pt[3].x = 2*xLeft-xRight; 
            pt[3].y = (yBottom + yTop) / 2; 
            Polygon(hdc, pt, 4);
            
        }
        if (Hinh == ID_HE)
        {
            pt[0].x = (xRight + xLeft) / 2;
            pt[0].y = yTop;
            pt[1].x = xLeft;
            pt[1].y = yBottom;
            pt[2].x = xRight;
            pt[2].y = yBottom;
            Polygon(hdc, pt, 3);
        }       
       ReleaseDC(hWnd, hdc);
        break;
    case WM_COMMAND:
        {
            int wmId = LOWORD(wParam);
            // Parse the menu selections:
            switch (wmId)
            {
                //hình thoi
            case ID_HT:
              
                //hình ellipse
            case 32781:
                Hinh = wmId;
                break;
                //xanh lá cây
            case ID_XLC:
                currentColor = RGB(0, 255, 0); 
                                break;
                //vàng
            case ID_Vang:
                currentColor = RGB(255, 255, 0);
                break;
                //gạch ngang
            case ID_GN:
                //Kieunen = HS_HORIZONTAL;
                currentHatchBrush = HS_HORIZONTAL; 
                break;
                //đan hình trám
            case ID_DHT:
                //Kieunen = HS_DIAGCROSS;
                currentHatchBrush = HS_DIAGCROSS;
               
                break;

            case 32782:
                if (MessageBox(NULL, TEXT("Bạn có muốn thoát kông?"), TEXT("Yes or No"), MB_YESNO | MB_ICONQUESTION) == IDYES)

                {
                    DeleteObject(hbrush);
                    DeleteObject(hpen); 
                    PostQuitMessage(0);
                }
                break;
            case IDM_ABOUT:
                DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
                break;
            case IDM_EXIT:
                DestroyWindow(hWnd);
                DeleteObject(hpen);
                DeleteObject(hbrush);
                break;
            default:
                return DefWindowProc(hWnd, message, wParam, lParam);
            }
        }
        break;
    case WM_PAINT:
        {
            PAINTSTRUCT ps;
            hdc = BeginPaint(hWnd, &ps);
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
