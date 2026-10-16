import type { Metadata } from "next";
import "./globals.css";

export const metadata: Metadata = {
  title: "فروشگاه اینترنتی دیجی‌کلون",
  description: "نسل بعدی خرید آنلاین با Next.js و .NET",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="fa" dir="rtl">
      <body className="antialiased bg-gray-50 text-gray-900 min-h-screen">
        {children}
      </body>
    </html>
  );
}
