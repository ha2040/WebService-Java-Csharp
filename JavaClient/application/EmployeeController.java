package application;


	
	import java.net.URL;
	import java.rmi.RemoteException;
	import java.sql.ResultSet;
	import java.sql.SQLException;
	import java.util.ArrayList;
	import java.util.Arrays;
	import java.util.ResourceBundle;

	import application.Main;
import javafx.beans.property.SimpleStringProperty;
import javafx.collections.FXCollections;
	import javafx.collections.ObservableList;
	import javafx.event.ActionEvent;
	import javafx.fxml.FXML;
	import javafx.fxml.FXMLLoader;
	import javafx.fxml.Initializable;
	import javafx.scene.*;
	import javafx.scene.control.*;
	import javafx.scene.control.cell.PropertyValueFactory;
	import javafx.scene.input.MouseEvent;
	import javafx.scene.layout.AnchorPane;
	import javafx.stage.Stage;

import se.lu.ics.EmployeeDTO;
import se.lu.ics.FacultyDTO;
import se.lu.ics.KebabUniServiceSoap;
import se.lu.ics.KebabUniServiceSoapProxy;


	public class EmployeeController implements Initializable {
		private Main main;
		private Stage stage;
		private Scene scene;
		private AnchorPane root;

		@FXML
		private TableView<EmployeeDTO> tblViewEmployee;

		@FXML
		private TableColumn<EmployeeDTO, String> columnId;

		@FXML
		private TableColumn<EmployeeDTO, String> columnName;

		@FXML
		private TableColumn<EmployeeDTO, String> columnFaculty;

		@FXML
		private TableColumn<EmployeeDTO, String> columnSalary;
	
		

		@FXML
		private TextField txtFieldAddress;
		@FXML
		private TextField txtFieldFirstName;
		@FXML
		private TextField txtFieldLastName;

		@FXML
		private TextField txtFieldJobTitle;

		@FXML
		private TextArea txtAreaEmployee;

		@FXML
		private TextField txtFieldId;
		@FXML
		private TextArea txtError;

	KebabUniServiceSoap web = new KebabUniServiceSoapProxy();
		ObservableList<EmployeeDTO> employeeList = FXCollections.observableArrayList();



		public void setMain(Main main) {
			this.main = main;
		}

		public Stage getStage() {
			return stage;
		}

		public void setStage(Stage stage) {
			this.stage = stage;
		}

		public Scene getScene() {
			return scene;
		}

		public void setScene(Scene scene) {
			this.scene = scene;
		}

		public AnchorPane getRoot() {
			return root;
		}

		public void setRoot(AnchorPane root) {
			this.root = root;
		}

		public Main getMain() {
			return main;
		}

		// Buttons to switch scenes

		@FXML
		public void btnSwitchToFaculties(ActionEvent event) throws Exception {
			FXMLLoader loader = new FXMLLoader(getClass().getResource("FacultyScene.fxml"));
			root = loader.load();
			stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
			scene = new Scene(root);

			stage.setScene(scene);
			stage.show();

			FacultyController facultyController = loader.getController();
			facultyController.setMain(main);
		}
		@FXML
		public void btnSwitchToEmployees(ActionEvent event) throws Exception {
			FXMLLoader loader = new FXMLLoader(getClass().getResource("EmployeeScene.fxml"));
			root = loader.load();
			stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
			scene = new Scene(root);

			stage.setScene(scene);
			stage.show();

			EmployeeController employeeController = loader.getController();
			employeeController.setMain(main);
		}


		// Buttons to change scenes
		@FXML
		public void btnSwitchToHome(ActionEvent event) throws Exception {
			FXMLLoader loader = new FXMLLoader(getClass().getResource("HomeScene.fxml"));
			root = loader.load();
			stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
			scene = new Scene(root);

			stage.setScene(scene);
			stage.show();

			HomeController homeController = loader.getController();
			homeController.setMain(main);
		}

		@FXML
		public void btnSwitchToStudents(ActionEvent event) throws Exception {
			FXMLLoader loader = new FXMLLoader(getClass().getResource("StudentsScene.fxml"));
			root = loader.load();
			stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
			scene = new Scene(root);

			stage.setScene(scene);
			stage.show();

			StudentsController studentsController = loader.getController();
			studentsController.setMain(main);
		}


		@FXML
		public void btnSwitchToCourses(ActionEvent event) throws Exception {
			FXMLLoader loader = new FXMLLoader(getClass().getResource("CoursesScene.fxml"));
			root = loader.load();
			stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
			scene = new Scene(root);

			stage.setScene(scene);
			stage.show();

			CoursesController coursesController = loader.getController();
			coursesController.setMain(main);
		}

		@FXML
		public void btnSwitchToExams(ActionEvent event) throws Exception {
			FXMLLoader loader = new FXMLLoader(getClass().getResource("ExamsScene.fxml"));
			root = loader.load();
			stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
			scene = new Scene(root);

			stage.setScene(scene);
			stage.show();

			ExamsController examsController = loader.getController();
			examsController.setMain(main);
		}

		

		@Override
		public void initialize(URL url, ResourceBundle resourceBundle) {
			
				 

			 try { 

				employeeList = FXCollections.observableArrayList(web.getEmployees());
			        
			    } catch (RemoteException e) {
			    	txtError.setText("something went wrong, please restart application and \n cand call support!");
			    }
				 

			columnId.setCellValueFactory(new PropertyValueFactory<>("empId"));
			columnName.setCellValueFactory(new PropertyValueFactory<>("employeeName"));
			columnFaculty.setCellValueFactory(cellData -> {
			    String facultyName = cellData.getValue().getFaculty().getFacultyId();
			    return new SimpleStringProperty(facultyName);
			});
			columnSalary.setCellValueFactory(new PropertyValueFactory<>("salary"));
			

			tblViewEmployee.setItems(employeeList);

		}

	}

//}
