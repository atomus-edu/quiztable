/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 5.12.1
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralWidget;
    QLabel *lblHome;
    QLabel *lblPuzzle;
    QLabel *lblTable;
    QLabel *lblSettings;
    QLabel *lblHelp;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName(QString::fromUtf8("MainWindow"));
        MainWindow->resize(810, 449);
        QSizePolicy sizePolicy(QSizePolicy::Preferred, QSizePolicy::Preferred);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(MainWindow->sizePolicy().hasHeightForWidth());
        MainWindow->setSizePolicy(sizePolicy);
        QPalette palette;
        QBrush brush(QColor(255, 255, 255, 255));
        brush.setStyle(Qt::SolidPattern);
        palette.setBrush(QPalette::Active, QPalette::Base, brush);
        QBrush brush1(QColor(90, 45, 174, 255));
        brush1.setStyle(Qt::SolidPattern);
        palette.setBrush(QPalette::Active, QPalette::Window, brush1);
        palette.setBrush(QPalette::Inactive, QPalette::Base, brush);
        palette.setBrush(QPalette::Inactive, QPalette::Window, brush1);
        palette.setBrush(QPalette::Disabled, QPalette::Base, brush1);
        palette.setBrush(QPalette::Disabled, QPalette::Window, brush1);
        MainWindow->setPalette(palette);
        centralWidget = new QWidget(MainWindow);
        centralWidget->setObjectName(QString::fromUtf8("centralWidget"));
        lblHome = new QLabel(centralWidget);
        lblHome->setObjectName(QString::fromUtf8("lblHome"));
        lblHome->setGeometry(QRect(0, 0, 40, 40));
        QPalette palette1;
        palette1.setBrush(QPalette::Active, QPalette::WindowText, brush);
        palette1.setBrush(QPalette::Inactive, QPalette::WindowText, brush);
        QBrush brush2(QColor(120, 120, 120, 255));
        brush2.setStyle(Qt::SolidPattern);
        palette1.setBrush(QPalette::Disabled, QPalette::WindowText, brush2);
        lblHome->setPalette(palette1);
        lblHome->setCursor(QCursor(Qt::PointingHandCursor));
        lblPuzzle = new QLabel(centralWidget);
        lblPuzzle->setObjectName(QString::fromUtf8("lblPuzzle"));
        lblPuzzle->setGeometry(QRect(0, 40, 40, 40));
        QPalette palette2;
        palette2.setBrush(QPalette::Active, QPalette::WindowText, brush);
        palette2.setBrush(QPalette::Inactive, QPalette::WindowText, brush);
        palette2.setBrush(QPalette::Disabled, QPalette::WindowText, brush2);
        lblPuzzle->setPalette(palette2);
        lblPuzzle->setCursor(QCursor(Qt::PointingHandCursor));
        lblTable = new QLabel(centralWidget);
        lblTable->setObjectName(QString::fromUtf8("lblTable"));
        lblTable->setGeometry(QRect(0, 80, 40, 40));
        QPalette palette3;
        palette3.setBrush(QPalette::Active, QPalette::WindowText, brush);
        palette3.setBrush(QPalette::Inactive, QPalette::WindowText, brush);
        palette3.setBrush(QPalette::Disabled, QPalette::WindowText, brush2);
        lblTable->setPalette(palette3);
        lblTable->setCursor(QCursor(Qt::PointingHandCursor));
        lblSettings = new QLabel(centralWidget);
        lblSettings->setObjectName(QString::fromUtf8("lblSettings"));
        lblSettings->setGeometry(QRect(0, 120, 40, 40));
        QPalette palette4;
        palette4.setBrush(QPalette::Active, QPalette::WindowText, brush);
        palette4.setBrush(QPalette::Inactive, QPalette::WindowText, brush);
        palette4.setBrush(QPalette::Disabled, QPalette::WindowText, brush2);
        lblSettings->setPalette(palette4);
        lblSettings->setCursor(QCursor(Qt::PointingHandCursor));
        lblHelp = new QLabel(centralWidget);
        lblHelp->setObjectName(QString::fromUtf8("lblHelp"));
        lblHelp->setGeometry(QRect(0, 410, 40, 40));
        QPalette palette5;
        palette5.setBrush(QPalette::Active, QPalette::WindowText, brush);
        palette5.setBrush(QPalette::Inactive, QPalette::WindowText, brush);
        palette5.setBrush(QPalette::Disabled, QPalette::WindowText, brush2);
        lblHelp->setPalette(palette5);
        lblHelp->setCursor(QCursor(Qt::PointingHandCursor));
        MainWindow->setCentralWidget(centralWidget);

        retranslateUi(MainWindow);

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QApplication::translate("MainWindow", "QuizTable", nullptr));
        lblHome->setText(QApplication::translate("MainWindow", "Home", nullptr));
        lblPuzzle->setText(QApplication::translate("MainWindow", "Puzzle", nullptr));
        lblTable->setText(QApplication::translate("MainWindow", "Table", nullptr));
        lblSettings->setText(QApplication::translate("MainWindow", "Settings", nullptr));
        lblHelp->setText(QApplication::translate("MainWindow", "Help", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
