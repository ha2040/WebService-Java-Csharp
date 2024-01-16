package application;

import java.awt.Button;
import javafx.event.ActionEvent;
import java.awt.event.KeyEvent;
import java.awt.event.MouseEvent;
import java.net.URL;
import java.rmi.RemoteException;
import java.util.ArrayList;
import java.util.Optional;
import java.util.ResourceBundle;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.ButtonType;
import javafx.scene.control.Label;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;
import javafx.scene.control.Alert.AlertType;
import se.lu.ics.FacultyDTO;
import se.lu.ics.KebabUniServiceSoap;
import se.lu.ics.KebabUniServiceSoapProxy;
import se.lu.ics.StudentDTO;

public class FacultyController implements Initializable {
	private KebabUniServiceSoap web = new KebabUniServiceSoapProxy();
    ObservableList<FacultyDTO> facultyList = FXCollections.observableArrayList();
	@FXML
	private TextArea txtError;
    private Main main;
    private Stage stage;
	private Scene scene;
	private AnchorPane root;

	    @FXML
	    private TableColumn<FacultyDTO, String> columnId;

	    @FXML
	    private TableColumn<FacultyDTO, String> columnName;

	    @FXML
	    private Label lblResponse;

	    @FXML
	    private Label lblResponseCourseName;

	    @FXML
	    private TableColumn<FacultyDTO, String> columnAddress;

	    @FXML
	    private TableView<FacultyDTO> tblViewFaculty;
	 
	   
	        
	    
	

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

	    @FXML
	    void tblViewOnKeyPressed(KeyEvent event) {

	    }

	    @FXML
	    void txtFieldOnPressingEnter(KeyEvent event) {

	    }
	    @Override
		public void initialize(URL url, ResourceBundle resourceBundle) {
			
				 

				    try { 
				        FacultyDTO[] facultyDtos = web.getFaculties();
				        
				        for (FacultyDTO faculty : facultyDtos) {
				        	FacultyDTO facultyCopy = new FacultyDTO(
				        			   faculty.getFacultyId(),
				        	           faculty.getFacultyName(),
				        	           faculty.getAddress(),
				        	           faculty.getEmployees() ,
				        	           faculty.getCourses()
				               
				            );
				        	facultyList.add(facultyCopy);
				            
				            
				          
				        }
				        
				    } catch (RemoteException e) {
				    	txtError.setText(e.getMessage());
				    }
				    
				 

			columnId.setCellValueFactory(new PropertyValueFactory<>("facultyId"));
			columnName.setCellValueFactory(new PropertyValueFactory<>("facultyName"));
			columnAddress.setCellValueFactory(new PropertyValueFactory<>("address"));
			
			tblViewFaculty.setItems(facultyList);

		}

	    
		public void setMain(Main main) {
			
			this.main = main;
		}
		public Main getMain() 
		{
			return this.main;
		}

	}



