// GraphicsExample.cpp : Defines the entry point for the application.
//

#include "framework.h"
#include "GraphicsExample.h"

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
    LoadStringW(hInstance, IDC_GRAPHICSEXAMPLE, szWindowClass, MAX_LOADSTRING);
    MyRegisterClass(hInstance);

    // Perform application initialization:
    if (!InitInstance (hInstance, nCmdShow))
    {
        return FALSE;
    }

    HACCEL hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_GRAPHICSEXAMPLE));

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
    wcex.hIcon          = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_GRAPHICSEXAMPLE));
    wcex.hCursor        = LoadCursor(nullptr, IDC_ARROW);
    wcex.hbrBackground  = (HBRUSH)(COLOR_WINDOW+1);
    wcex.lpszMenuName   = MAKEINTRESOURCEW(IDC_GRAPHICSEXAMPLE);
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
    static POINT pt[10000];
    static int count = 0;
    HDC hdc;

    static int x, y;
    
    static HPEN hpen,hpenBlue, hpenRed; // tạo bút vẽ
    static HBRUSH hbrushYellow, hbrushViolet;
    switch (message)
    {
    //case WM_LBUTTONDOWN:
    //    pt[count].x = LOWORD(lParam);
    //    pt[count].y = HIWORD(lParam);
    //    hdc = GetDC(hWnd);
    //    if (count ==0)
    //    {
    //        SetPixel(hdc, pt[count].x, pt[count].y, RGB(0, 0, 0));
    //        MoveToEx(hdc, pt[count].x, pt[count].y, NULL);

    //    }
    //    else
    //    {
    //        MoveToEx(hdc, pt[count - 1].x, pt[count - 1].y, NULL);
    //        LineTo(hdc, pt[count].x, pt[count].y );
    //    }
    //    count++;
    //    Polyline(hdc, pt, count);   // 
    //    ReleaseDC(hWnd, hdc);
    //    break;
        
    case WM_SIZE:
        x = LOWORD(lParam);
        y = HIWORD(lParam);
        hpenBlue = CreatePen(PS_DASH, 1, RGB(0, 0, 255));   // tạo bút vẽ xanh
        hpenRed = CreatePen(PS_SOLID, 3, RGB(255, 0, 0));   // tạo bút vẽ đỏ
        hbrushYellow = CreateSolidBrush(RGB(255, 255, 0));
        hbrushViolet = CreateHatchBrush(HS_DIAGCROSS, RGB(238,130, 238));

        hdc = GetDC(hWnd); // ngữ cảnh thiết bị đc gắn cho cửa sổ hWnd
        MoveToEx(hdc, 0, 0, NULL);
        LineTo(hdc, x, y);
        MoveToEx(hdc, 0, y,NULL);
        LineTo(hdc, x, 0);
        hpen = (HPEN)GetStockObject(BLACK_PEN);
        SelectObject(hdc, hpenRed);
        SelectObject(hdc, hbrushYellow);
        Rectangle(hdc, x / 8, y / 8, x * 7 / 8, y * 7 / 8);

        SelectObject(hdc, hbrushViolet);
        Ellipse(hdc, x / 8, y / 8, x * 7 / 8, y * 7 / 8);

        ReleaseDC(hWnd, hdc);
        break;
    //case WM_LBUTTONDOWN: // thong diep nhan chuot trai
      
        x = LOWORD(lParam);
        y = HIWORD(lParam);
        hdc = GetDC(hWnd);
        for(int i = 0 ; i<=50; i++)
        SetPixel(hdc, x + i , y, RGB(0, 0, 255));
        ReleaseDC(hWnd, hdc);
        break;
    case WM_COMMAND:
        {
            int wmId = LOWORD(wParam);
            // Parse the menu selections:
            switch (wmId)
            {
            case IDM_ABOUT:
                DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
                break;
            case IDM_EXIT:
                DestroyWindow(hWnd);
                break;
            default:
                return DefWindowProc(hWnd, message, wParam, lParam);
            }
        }
        break;
    case WM_PAINT:
        {
            //PAINTSTRUCT ps;
            //HDC hdc = BeginPaint(hWnd, &ps);
            //// TODO: Add any drawing code that uses hdc here...
            //for(int i=50;i<=100;i++)
            //SetPixel(hdc, i, 30, RGB(255, 0, 0));   // Vẽ các điểm ảnh
            //EndPaint(hWnd, &ps);    // Giải phóng ngữ cảnh thiết bị
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
