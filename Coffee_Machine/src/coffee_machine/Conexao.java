/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package coffee_machine;

/**
 *
 * @author aluno
 */

       import java.sql.Statement;
       import java.sql.Connection;
       import java.sql.DriverManager;
       import java.sql.ResultSet;
       import java.sql.SQLException;

public class Conexao {
    
           public static Statement statement = null;

           String url = "jdbc:mysql://localhost:3307/aluno_2dsa_jaqueline_bd_vendas";
       
           String usuario = "root";
       
           String senha = "usbw";
      
           private Statement stm = null;
       
          public Connection conecta = null;
          
       public void conectar() throws ClassNotFoundException, SQLException 
       {
            Class.forName("com.mysql.jdbc.Driver");
            conecta = DriverManager.getConnection(url, usuario, senha);
            statement = (Statement) conecta.createStatement(ResultSet.TYPE_SCROLL_SENSITIVE,ResultSet.CONCUR_UPDATABLE);
       }

       public void desconectar() throws SQLException
       {
               conecta.close();
       }
   
      public static int runSQL(String sql) 
      {
           int qtdreg = 0;
     
           try
          {
               qtdreg = statement.executeUpdate(sql);
          }
          catch(SQLException sqlex)
         {
           System.out.println("Erro acesso ao BD"+ sqlex);
         }

         return qtdreg;
      }
      
      public ResultSet buscacafe()
      {
          try{
          statement=conecta.createStatement();
          ResultSet rs = statement.executeQuery("SELECT * FROM tb01_produtos");
          return rs;
          }catch (SQLException e){
           e.printStackTrace();    
          }
          return null;
      }
}
