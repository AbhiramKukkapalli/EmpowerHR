using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_API.Migrations
{
    public partial class AddBlogCreatedTimestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACCESS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_ID = table.Column<int>(nullable: true),
                    MENU_A = table.Column<int>(nullable: true),
                    MENU_B = table.Column<int>(nullable: true),
                    MENU_C = table.Column<int>(nullable: true),
                    MENU_D = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCESS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ATTENDANCE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE = table.Column<int>(nullable: true),
                    DATE = table.Column<DateTime>(type: "date", nullable: true),
                    IN_TIME = table.Column<DateTime>(type: "datetime", nullable: true),
                    OUT_TIME = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATTENDANCE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BANK_NAME",
                columns: table => new
                {
                    B_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    B_NAME = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANK_NAME", x => x.B_ID);
                });

            migrationBuilder.CreateTable(
                name: "BLOOD_GROUP",
                columns: table => new
                {
                    B_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BLOOD_NAME = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLOOD_GROUP", x => x.B_ID);
                });

            migrationBuilder.CreateTable(
                name: "BRANCH",
                columns: table => new
                {
                    B_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BRANCH_NAME = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRANCH", x => x.B_ID);
                });

            migrationBuilder.CreateTable(
                name: "DEPARTMENT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DEP_NAME = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEPARTMENT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EMP_INFO",
                columns: table => new
                {
                    EMP_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FRIST_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    NAME_SURENAME = table.Column<string>(maxLength: 50, nullable: true),
                    DOB = table.Column<DateTime>(type: "date", nullable: true),
                    MOBILE = table.Column<int>(nullable: true),
                    NIC = table.Column<string>(maxLength: 50, nullable: true),
                    EMAIL = table.Column<string>(maxLength: 50, nullable: true),
                    BLOOD_ID = table.Column<int>(nullable: true),
                    ADDRESS = table.Column<string>(maxLength: 100, nullable: true),
                    GENDER = table.Column<int>(nullable: true),
                    CREATE_EMP_ID = table.Column<int>(nullable: true),
                    EMP_CREATE_DATE = table.Column<DateTime>(type: "date", nullable: true),
                    LANGUAGE = table.Column<int>(nullable: true),
                    STATUS = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_1", x => x.EMP_ID);
                });

            migrationBuilder.CreateTable(
                name: "EMP_WORK_INFO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_ID = table.Column<int>(nullable: true),
                    B_ID = table.Column<int>(nullable: true),
                    RE_EMP_ID = table.Column<int>(nullable: true),
                    DESCRIPTION = table.Column<string>(maxLength: 250, nullable: true),
                    W_T_ID = table.Column<int>(nullable: true),
                    P_ID = table.Column<int>(nullable: true),
                    D_ID = table.Column<int>(nullable: true),
                    DOF_A = table.Column<DateTime>(name: "D/OF_A", type: "date", nullable: true),
                    DOF_C = table.Column<DateTime>(name: "D/OF_C", type: "date", nullable: true),
                    DOF_JOIN = table.Column<DateTime>(name: "D/OF_JOIN", type: "date", nullable: true),
                    NFC_NUMBER = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMP_WORK_INFO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GENDER",
                columns: table => new
                {
                    G_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GENDER = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GENDER", x => x.G_ID);
                });

            migrationBuilder.CreateTable(
                name: "LANGUAGE",
                columns: table => new
                {
                    L_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LANGUAGE = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LANGUAGE", x => x.L_ID);
                });

            migrationBuilder.CreateTable(
                name: "LAST_UPDATE_T",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QUANTITY = table.Column<int>(nullable: true),
                    DATE = table.Column<DateTime>(type: "date", nullable: true),
                    EMP_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LAST_UPDATE_T", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PASS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_ID = table.Column<int>(nullable: true),
                    USER_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    PASS = table.Column<string>(maxLength: 150, nullable: true),
                    LOG_IN_OUT = table.Column<int>(nullable: true),
                    LOCK1 = table.Column<int>(nullable: true),
                    LOCK2 = table.Column<int>(nullable: true),
                    CREAT_EMP_ID = table.Column<int>(nullable: true),
                    CREAT_DATE = table.Column<DateTime>(type: "date", nullable: true),
                    BRANCH_ID = table.Column<int>(nullable: true),
                    Path = table.Column<string>(maxLength: 100, nullable: true),
                    LAST_L_DATE_TIME = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PASS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "POSITION",
                columns: table => new
                {
                    P_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POSITION_NAME = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    D_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSITION", x => x.P_ID);
                });

            migrationBuilder.CreateTable(
                name: "SALE_T_SHIRT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_S_N_ID = table.Column<int>(nullable: true),
                    T_S_SIZE_ID = table.Column<int>(nullable: true),
                    EMP_ID = table.Column<int>(nullable: true),
                    DATE = table.Column<DateTime>(type: "date", nullable: true),
                    B_ID = table.Column<int>(nullable: true),
                    RESIPT_NO = table.Column<string>(maxLength: 50, nullable: true),
                    STATES = table.Column<int>(nullable: true),
                    QUANTITY = table.Column<int>(nullable: true),
                    ODER_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_T_SHIRT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "STATUS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STATUS = table.Column<string>(unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATUS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_SHIRT_NAME",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    PRICE = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SHIRT_NAME", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_SHIRT_SIZE",
                columns: table => new
                {
                    SIZE_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIZE_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    LENGTH = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    WIDTH = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SHART_SIZE", x => x.SIZE_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_SHIRT_STOCK",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_S_N_ID = table.Column<int>(nullable: true),
                    T_S_SIZE_ID = table.Column<int>(nullable: true),
                    T_STOCK_QUANTITY = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SHIRT_STOCK", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TEST",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TEST = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DATE = table.Column<DateTime>(type: "date", nullable: true),
                    OUT_DATE = table.Column<DateTime>(type: "date", nullable: true),
                    SEARCH = table.Column<string>(maxLength: 1, nullable: true),
                    SEARCH_2 = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEST", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TEST_2",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TEST = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEST_2", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WORK_TYPE",
                columns: table => new
                {
                    W_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    W_NAME = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORK_TYPE", x => x.W_ID);
                });

            migrationBuilder.CreateTable(
                name: "NOTICE",
                columns: table => new
                {
                    NO_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D_ID = table.Column<int>(nullable: true),
                    P_ID = table.Column<int>(nullable: true),
                    EMP_ID = table.Column<int>(nullable: true),
                    TO_DATE = table.Column<DateTime>(type: "date", nullable: true),
                    FROM = table.Column<DateTime>(type: "date", nullable: true),
                    N_TITEL = table.Column<string>(maxLength: 100, nullable: true),
                    N_BODY = table.Column<string>(maxLength: 500, nullable: true),
                    N_PUT_ID = table.Column<int>(nullable: true),
                    N_FROM_ALL = table.Column<int>(nullable: true),
                    PUT_P_ID = table.Column<int>(nullable: true),
                    N_L_UPDATE_DATE = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOTICE", x => x.NO_ID);
                    table.ForeignKey(
                        name: "FK_NOTICE_POSITION",
                        column: x => x.PUT_P_ID,
                        principalTable: "POSITION",
                        principalColumn: "P_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NOTICE_PUT_P_ID",
                table: "NOTICE",
                column: "PUT_P_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACCESS");

            migrationBuilder.DropTable(
                name: "ATTENDANCE");

            migrationBuilder.DropTable(
                name: "BANK_NAME");

            migrationBuilder.DropTable(
                name: "BLOOD_GROUP");

            migrationBuilder.DropTable(
                name: "BRANCH");

            migrationBuilder.DropTable(
                name: "DEPARTMENT");

            migrationBuilder.DropTable(
                name: "EMP_INFO");

            migrationBuilder.DropTable(
                name: "EMP_WORK_INFO");

            migrationBuilder.DropTable(
                name: "GENDER");

            migrationBuilder.DropTable(
                name: "LANGUAGE");

            migrationBuilder.DropTable(
                name: "LAST_UPDATE_T");

            migrationBuilder.DropTable(
                name: "NOTICE");

            migrationBuilder.DropTable(
                name: "PASS");

            migrationBuilder.DropTable(
                name: "SALE_T_SHIRT");

            migrationBuilder.DropTable(
                name: "STATUS");

            migrationBuilder.DropTable(
                name: "T_SHIRT_NAME");

            migrationBuilder.DropTable(
                name: "T_SHIRT_SIZE");

            migrationBuilder.DropTable(
                name: "T_SHIRT_STOCK");

            migrationBuilder.DropTable(
                name: "TEST");

            migrationBuilder.DropTable(
                name: "TEST_2");

            migrationBuilder.DropTable(
                name: "WORK_TYPE");

            migrationBuilder.DropTable(
                name: "POSITION");
        }
    }
}
