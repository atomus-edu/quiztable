#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QPixmap>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    QPixmap picHome(":/resource/img/home_white.png");
    QPixmap picPuzzle(":/resource/img/puzzle_white.png");
    QPixmap picTable(":/resource/img/table_white.png");
    QPixmap picSettings(":/resource/img/settings_white.png");
    QPixmap picHelp(":/resource/img/question_white.png");
    int w = ui->lblHome->width();
    int h = ui->lblHome->height();

    ui->lblHome->setPixmap(picHome.scaled(w, h, Qt::KeepAspectRatio));
    ui->lblPuzzle->setPixmap(picPuzzle.scaled(w, h, Qt::KeepAspectRatio));
    ui->lblTable->setPixmap(picTable.scaled(w, h, Qt::KeepAspectRatio));
    ui->lblSettings->setPixmap(picSettings.scaled(w, h, Qt::KeepAspectRatio));
    ui->lblHelp->setPixmap(picHelp.scaled(w, h, Qt::KeepAspectRatio));
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_pushButton_clicked()
{

}
