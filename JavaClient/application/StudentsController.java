package application;

import java.net.URL;
import java.rmi.RemoteException;
import java.util.Optional;
import java.util.ResourceBundle;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.Alert.AlertType;
import javafx.scene.control.Button;
import javafx.scene.control.ButtonType;
import javafx.scene.control.Label;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.input.KeyCode;
import javafx.scene.input.KeyEvent;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;
import se.lu.ics.KebabUniServiceSoap;
import se.lu.ics.KebabUniServiceSoapProxy;
import se.lu.ics.StudentDTO;

public class StudentsController implements Initializable {
	private KebabUniServiceSoap web = new KebabUniServiceSoapProxy();
	private ObservableList<StudentDTO> sList= FXCollections.observableArrayList();
	private Main main;
	private Stage stage;
	private Scene scene;
	private AnchorPane root;
	private String inLineCss = "-fx-border-style: solid; -fx-border-radius: 3px; -fx-border-width: 0.4px; -fx-border-color: red";
	private String inLineCssHide = "-fx-border-: transparent";
	@FXML
	private TextArea txtError;

	@FXML
	private TableView<StudentDTO> tblViewStudents;

	@FXML
	private TableColumn<StudentDTO, String> columnName;

	@FXML
	private TableColumn<StudentDTO, String> columnAddress;

	@FXML
	private TableColumn<StudentDTO, String> columnStudentId;

	@FXML
	private TextField txtFieldName;

	@FXML
	private TextField txtFieldAddress;

	@FXML
	private TextField txtFieldSearch;

	@FXML
	private Label lblResponse;

	@FXML
	private Label lblResponseFirstName;

	@FXML
	private Label lblResponseLastName;

	@FXML
	private Button btnCreateStudent;

	@FXML
	private Button btnDeleteStudent;

	@FXML
	private Button btnViewResults;

	@FXML
	private Button btnUpdateStudent;


	public Main getMain() {
		return main;
	}

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

	public String getInLineCss() {
		return inLineCss;
	}

	public void setInLineCss(String inLineCss) {
		this.inLineCss = inLineCss;
	}

	public String getInLineCssHide() {
		return inLineCssHide;
	}

	public void setInLineCssHide(String inLineCssHide) {
		this.inLineCssHide = inLineCssHide;
	}

	// methods

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

	public void initData() {
    	tblViewStudents.setItems(sList);
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

	// sets up the columns
	@Override
	public void initialize(URL url, ResourceBundle resourceBundle) {
		
		 try { 
		        StudentDTO[] studentDtos = web.getStudents();
		        
		        for (StudentDTO student : studentDtos) {
		        	StudentDTO studentCopy = new StudentDTO(
		        			student.getStudentName(),
		        			student.getStudentId(),
		        			student.getAddress(),
		        			student.getResultList(),
		        			student.getStudentStudyList()
		              
		               
		            );
		            sList.add(studentCopy);
		         
		            
		          
		        }
		        
		    } catch (RemoteException e) {
		    	txtError.setText("something went wrong, please restart application and \n cand call support!");
		    }


      
        	columnStudentId.setCellValueFactory(new PropertyValueFactory<>("studentId"));
          	columnName.setCellValueFactory(new PropertyValueFactory<>("studentName"));
        	columnAddress.setCellValueFactory(new PropertyValueFactory<>("Address"));
        	tblViewStudents.setItems(sList);
	}

}
