package application;

import java.awt.Button;
import javafx.event.ActionEvent;
import java.awt.event.KeyEvent;
import java.awt.event.MouseEvent;
import java.net.URL;
import java.rmi.RemoteException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Optional;
import java.util.ResourceBundle;

import javafx.beans.property.SimpleStringProperty;
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
import se.lu.ics.StudentStudyDTO;
import se.lu.ics.FacultyDTO;
import se.lu.ics.KebabUniServiceSoap;
import se.lu.ics.KebabUniServiceSoapProxy;
import se.lu.ics.StudentDTO;

public class StudentStudyController implements Initializable {
	private KebabUniServiceSoap web = new KebabUniServiceSoapProxy();
    ObservableList<StudentStudyDTO> studentStudyList = FXCollections.observableArrayList();
	
	

    @FXML
    private TableColumn<StudentStudyDTO, String> columnCourseId;

    @FXML
    private TableColumn<StudentStudyDTO, String> columnEndDate;

    @FXML
    private TableColumn<StudentStudyDTO, String> columnStartDate;

    @FXML
    private TableColumn<StudentStudyDTO, String> columnStudentId;

    @FXML
    private Label lblResponse;

    @FXML
    private TableView<StudentStudyDTO> tblViewStudentStudy;
    
    @FXML
    private TextArea txtError;
    private Main main;
    private Stage stage;
	private Scene scene;
	private AnchorPane root;

	

    @FXML
    void btnSwitchToCourses(ActionEvent event) throws Exception{
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
    void btnSwitchToEmployees(ActionEvent event) throws Exception{
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
    void btnSwitchToExams(ActionEvent event)throws Exception {
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
    void btnSwitchToFaculties(ActionEvent event) throws Exception{
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
    void btnSwitchToHome(ActionEvent event) throws Exception{
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
    void btnSwitchToStudents(ActionEvent event) throws Exception{
    	FXMLLoader loader = new FXMLLoader(getClass().getResource("StudentsScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		StudentsController studentsController = loader.getController();
		studentsController.setMain(main);

    }
    
    
    @Override
		public void initialize(URL url, ResourceBundle resourceBundle) {
			
				 

				    try { 
				        StudentStudyDTO[] studentStudyDtos = web.getStudentStudy();
				        
				        for (StudentStudyDTO studentStudy : studentStudyDtos) {
				        	StudentStudyDTO studentStudyCopy = new StudentStudyDTO(
				        			studentStudy.getCourse(),
				        			studentStudy.getStudent(),
				        			studentStudy.getStartDate() ,
				        			studentStudy.getEndDate()
				               
				            );
				        	studentStudyList.add(studentStudyCopy);
				            
				            
				          
				        }
				        
				    } catch (RemoteException e) {
				    	txtError.setText("something went wrong, please restart application and \n cand call support!");
				    }
				    
				 

					columnStudentId.setCellValueFactory(cellData -> {
					    String studentId = cellData.getValue().getStudent().getStudentId();
					    return new SimpleStringProperty(studentId);
					});
					columnCourseId.setCellValueFactory(cellData -> {
					    String courseId = cellData.getValue().getCourse().getCourseId();
					    return new SimpleStringProperty(courseId);
					});
					columnStartDate.setCellValueFactory(cellData -> {
					    SimpleStringProperty property = new SimpleStringProperty();
					    if (cellData.getValue().getStartDate() != null) {
					        DateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd");
					        property.setValue(dateFormat.format(cellData.getValue().getStartDate().getTime()));
					    }
					    return property;
					});

					columnEndDate.setCellValueFactory(cellData -> {
					    SimpleStringProperty property = new SimpleStringProperty();
					    if (cellData.getValue().getEndDate() != null) {
					        DateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd");
					        property.setValue(dateFormat.format(cellData.getValue().getEndDate().getTime()));
					    }
					    return property;
					});
			
			tblViewStudentStudy.setItems(studentStudyList);

		}
    
    public void setMain(Main main) {
		
		this.main = main;
	}
	public Main getMain() 
	{
		return this.main;
	}
		

}

